namespace Text_to_Speech
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listenBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textToRead = new System.Windows.Forms.TextBox();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sliderVolume = new System.Windows.Forms.TrackBar();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.rateLbl = new System.Windows.Forms.Label();
            this.sliderRate = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRate)).BeginInit();
            this.SuspendLayout();
            // 
            // listenBtn
            // 
            this.listenBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.listenBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listenBtn.Location = new System.Drawing.Point(594, 335);
            this.listenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(89, 57);
            this.listenBtn.TabIndex = 0;
            this.listenBtn.Text = "Listen";
            this.listenBtn.UseVisualStyleBackColor = false;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(704, 335);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 57);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            // 
            // textToRead
            // 
            this.textToRead.Location = new System.Drawing.Point(44, 144);
            this.textToRead.Margin = new System.Windows.Forms.Padding(2);
            this.textToRead.Multiline = true;
            this.textToRead.Name = "textToRead";
            this.textToRead.Size = new System.Drawing.Size(750, 187);
            this.textToRead.TabIndex = 3;
            // 
            // cmbVoice
            // 
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(44, 67);
            this.cmbVoice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(269, 21);
            this.cmbVoice.TabIndex = 4;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.DarkRed;
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopBtn.Location = new System.Drawing.Point(467, 335);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(104, 57);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voice";
            // 
            // sliderVolume
            // 
            this.sliderVolume.Location = new System.Drawing.Point(414, 67);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(157, 45);
            this.sliderVolume.TabIndex = 7;
            this.sliderVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderVolume.Value = 100;
            this.sliderVolume.Scroll += new System.EventHandler(this.sliderVolume_Scroll);
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(425, 42);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(42, 13);
            this.volumeLbl.TabIndex = 8;
            this.volumeLbl.Text = "Volume";
            // 
            // rateLbl
            // 
            this.rateLbl.AutoSize = true;
            this.rateLbl.Location = new System.Drawing.Point(653, 42);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(30, 13);
            this.rateLbl.TabIndex = 9;
            this.rateLbl.Text = "Rate";
            // 
            // sliderRate
            // 
            this.sliderRate.Location = new System.Drawing.Point(639, 67);
            this.sliderRate.Minimum = -10;
            this.sliderRate.Name = "sliderRate";
            this.sliderRate.Size = new System.Drawing.Size(154, 45);
            this.sliderRate.TabIndex = 11;
            this.sliderRate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderRate.Value = 1;
            this.sliderRate.Scroll += new System.EventHandler(this.sliderRate_Scroll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 424);
            this.Controls.Add(this.sliderRate);
            this.Controls.Add(this.rateLbl);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.sliderVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.cmbVoice);
            this.Controls.Add(this.textToRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.listenBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listenBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textToRead;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sliderVolume;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label rateLbl;
        private System.Windows.Forms.TrackBar sliderRate;
    }
}

