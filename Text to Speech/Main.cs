using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;


namespace Text_to_Speech
{
    public partial class Main : Form
    {
        SpeechSynthesizer speechSynthesizer;
        int audioCount = 0;


        public Main()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInstalledVoices();
            UpdateRateLabel();
            UpdateVolumeLabel();
            textToRead.Text = "Hellow World!";
        }

        private void sliderRate_Scroll(object sender, EventArgs e)
        {
            UpdateRateLabel();
        }

        private void sliderVolume_Scroll(object sender, EventArgs e)
        {
            UpdateVolumeLabel();
        }
        
        private void stopBtn_Click(object sender, EventArgs e)
        {
            StopSynthesizer();
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            ReInitSynthesizer();
            speechSynthesizer.SpeakAsync(textToRead.Text);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ReInitSynthesizer();
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\Audio Files\\";
            Directory.CreateDirectory(path);
            var audioName = "Audio" + this.audioCount.ToString() + ".wav";
            speechSynthesizer.SetOutputToWaveFile(path + audioName);
            speechSynthesizer.SpeakAsync(textToRead.Text);

            this.audioCount++;
        }


        #region Local helpers
        private void LoadInstalledVoices()
        {
            speechSynthesizer = new SpeechSynthesizer();
            var voices = speechSynthesizer.GetInstalledVoices();
            foreach (InstalledVoice voice in voices)
            {
                VoiceInfo infoVoice = voice.VoiceInfo;
                cmbVoice.Items.Add(infoVoice.Name);
            }
            cmbVoice.SelectedItem = speechSynthesizer.Voice.Name;
            speechSynthesizer.Dispose();
        }
        private void ReInitSynthesizer()
        {
            StopSynthesizer();
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SpeakStarted += new EventHandler<SpeakStartedEventArgs>(SynthesizerSpeakStarted);
            speechSynthesizer.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SynthesizerSpeakCompleted);
            ConfigureSynthesizerParams();
        }
        private void ConfigureSynthesizerParams()
        {
            speechSynthesizer.SelectVoice(cmbVoice.SelectedItem as string);
            speechSynthesizer.Volume = Convert.ToInt32(sliderVolume.Value);
            speechSynthesizer.Rate = Convert.ToInt32(sliderRate.Value);
        }
        private void StopSynthesizer()
        {
            try
            {
                if (speechSynthesizer != null && speechSynthesizer.State == SynthesizerState.Speaking)
                {
                    speechSynthesizer.Dispose();
                }
            }
            catch (Exception ex) { }
        }
        private void UpdateRateLabel()
        {
            rateLbl.Text = "Rate: " + sliderRate.Value.ToString();
        }
        private void UpdateVolumeLabel()
        {
            volumeLbl.Text = "Volume: " + sliderVolume.Value.ToString();
        }
        private void SynthesizerSpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            stopBtn.Enabled = true;
            //stopBtn.Visible = true;
        }
        private void SynthesizerSpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            stopBtn.Enabled = false;
            //stopBtn.Visible = false;
        }
        #endregion
    }
}
