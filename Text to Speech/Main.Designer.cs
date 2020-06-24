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
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notificationLbl = new System.Windows.Forms.TextBox();
            this.selectActiveTextBtn = new System.Windows.Forms.Button();
            this.ssmlMarkupLangListBox = new System.Windows.Forms.ListBox();
            this.resetSsmlMarkupLangListBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRate)).BeginInit();
            this.SuspendLayout();
            // 
            // listenBtn
            // 
            this.listenBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.listenBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listenBtn.Location = new System.Drawing.Point(662, 432);
            this.listenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(104, 66);
            this.listenBtn.TabIndex = 0;
            this.listenBtn.Text = "Listen";
            this.listenBtn.UseVisualStyleBackColor = false;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(791, 432);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(104, 66);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            // 
            // textToRead
            // 
            this.textToRead.HideSelection = false;
            this.textToRead.Location = new System.Drawing.Point(20, 174);
            this.textToRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textToRead.Multiline = true;
            this.textToRead.Name = "textToRead";
            this.textToRead.Size = new System.Drawing.Size(616, 216);
            this.textToRead.TabIndex = 3;
            // 
            // cmbVoice
            // 
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(20, 43);
            this.cmbVoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(253, 23);
            this.cmbVoice.TabIndex = 4;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.DarkRed;
            this.stopBtn.Enabled = false;
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopBtn.Location = new System.Drawing.Point(514, 432);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(122, 66);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voice";
            // 
            // sliderVolume
            // 
            this.sliderVolume.Location = new System.Drawing.Point(327, 34);
            this.sliderVolume.Margin = new System.Windows.Forms.Padding(4);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(357, 45);
            this.sliderVolume.TabIndex = 7;
            this.sliderVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderVolume.Value = 100;
            this.sliderVolume.Scroll += new System.EventHandler(this.sliderVolume_Scroll);
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(334, 15);
            this.volumeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(49, 15);
            this.volumeLbl.TabIndex = 8;
            this.volumeLbl.Text = "Volume";
            // 
            // rateLbl
            // 
            this.rateLbl.AutoSize = true;
            this.rateLbl.Location = new System.Drawing.Point(723, 9);
            this.rateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(33, 15);
            this.rateLbl.TabIndex = 9;
            this.rateLbl.Text = "Rate";
            // 
            // sliderRate
            // 
            this.sliderRate.Location = new System.Drawing.Point(716, 34);
            this.sliderRate.Margin = new System.Windows.Forms.Padding(4);
            this.sliderRate.Minimum = -10;
            this.sliderRate.Name = "sliderRate";
            this.sliderRate.Size = new System.Drawing.Size(179, 45);
            this.sliderRate.TabIndex = 11;
            this.sliderRate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderRate.Scroll += new System.EventHandler(this.sliderRate_Scroll);
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(20, 112);
            this.fileNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(253, 21);
            this.fileNameTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "File name";
            // 
            // notificationLbl
            // 
            this.notificationLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.notificationLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notificationLbl.Enabled = false;
            this.notificationLbl.ForeColor = System.Drawing.Color.Green;
            this.notificationLbl.Location = new System.Drawing.Point(20, 407);
            this.notificationLbl.Name = "notificationLbl";
            this.notificationLbl.Size = new System.Drawing.Size(875, 14);
            this.notificationLbl.TabIndex = 16;
            this.notificationLbl.Text = "Notification text";
            this.notificationLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // selectActiveTextBtn
            // 
            this.selectActiveTextBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.selectActiveTextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectActiveTextBtn.Location = new System.Drawing.Point(390, 432);
            this.selectActiveTextBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectActiveTextBtn.Name = "selectActiveTextBtn";
            this.selectActiveTextBtn.Size = new System.Drawing.Size(104, 66);
            this.selectActiveTextBtn.TabIndex = 17;
            this.selectActiveTextBtn.Text = "Select Text";
            this.selectActiveTextBtn.UseVisualStyleBackColor = false;
            this.selectActiveTextBtn.Click += new System.EventHandler(this.selectActiveTextBtn_Click);
            // 
            // ssmlMarkupLangListBox
            // 
            this.ssmlMarkupLangListBox.FormattingEnabled = true;
            this.ssmlMarkupLangListBox.ItemHeight = 15;
            this.ssmlMarkupLangListBox.Location = new System.Drawing.Point(644, 174);
            this.ssmlMarkupLangListBox.Name = "ssmlMarkupLangListBox";
            this.ssmlMarkupLangListBox.Size = new System.Drawing.Size(251, 169);
            this.ssmlMarkupLangListBox.TabIndex = 19;
            // 
            // resetSsmlMarkupLangListBox
            // 
            this.resetSsmlMarkupLangListBox.Location = new System.Drawing.Point(644, 143);
            this.resetSsmlMarkupLangListBox.Name = "resetSsmlMarkupLangListBox";
            this.resetSsmlMarkupLangListBox.Size = new System.Drawing.Size(33, 23);
            this.resetSsmlMarkupLangListBox.TabIndex = 20;
            this.resetSsmlMarkupLangListBox.Text = "<<";
            this.resetSsmlMarkupLangListBox.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 501);
            this.Controls.Add(this.resetSsmlMarkupLangListBox);
            this.Controls.Add(this.ssmlMarkupLangListBox);
            this.Controls.Add(this.selectActiveTextBtn);
            this.Controls.Add(this.notificationLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameTxt);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox notificationLbl;
        private System.Windows.Forms.Button selectActiveTextBtn;
        private System.Windows.Forms.ListBox ssmlMarkupLangListBox;
        private System.Windows.Forms.Button resetSsmlMarkupLangListBox;
    }
}

