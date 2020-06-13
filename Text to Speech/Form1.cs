using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;


namespace Text_to_Speech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speechSynthesizer;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            speechSynthesizer = new SpeechSynthesizer();

            foreach (InstalledVoice voice in speechSynthesizer.GetInstalledVoices())
            {
                VoiceInfo infoVoice = voice.VoiceInfo;
                cmbVoice.Items.Add(infoVoice.Name);
            }
            cmbVoice.SelectedItem = speechSynthesizer.Voice.Name;
            speechSynthesizer.Dispose();

            textToRead.Text = "Hellow World!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (speechSynthesizer != null && speechSynthesizer.State == SynthesizerState.Speaking)
                {
                    speechSynthesizer.Dispose();
                }
            }catch(Exception ex) { }

            speechSynthesizer = new SpeechSynthesizer();
            string toSpeak = textToRead.Text;

            //speechSynthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);


            speechSynthesizer.SelectVoice(cmbVoice.SelectedItem as string);
            speechSynthesizer.SpeakAsync(toSpeak);

            if (speechSynthesizer.State == SynthesizerState.Paused)
            {
                speechSynthesizer.Resume();
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (speechSynthesizer.State == SynthesizerState.Speaking)
            {
                speechSynthesizer.Dispose();
            }
        }
    }
}
