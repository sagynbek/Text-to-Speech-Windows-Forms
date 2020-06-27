using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_to_Speech
{
    class SsmlOptionsController
    {
        ListBox listBox;
        TextBox textToRead;
        Button resetButton;
        List<SsmlOption> options = new List<SsmlOption>();
        List<string> trackUserOptions = new List<string>();
        TextBox breadcrumbText;

        public SsmlOptionsController(Button resetButton, ListBox listBox, TextBox textBox, TextBox ssmlOptionBreadcrumbTxt)
        {
            this.listBox = listBox;
            this.textToRead = textBox;
            this.breadcrumbText = ssmlOptionBreadcrumbTxt;
            this.resetButton = resetButton;

            this.InitializeOptions();

            this.listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDown);
            this.listBox.DoubleClick += new System.EventHandler(this.HandleDoubleClick);
            this.resetButton.Click += new System.EventHandler(this.resetSsmlMarkupLangListBox_Click);

            resetButton.Visible = false;
            this.SetItems();
        }

        private void InitializeOptions()
        {
            this.options.Clear();

            {
                SsmlOption breakOption = new SsmlOption("break", "Break", OptionType.Insert);

                SsmlOption strengthOption = new SsmlOption("strength");
                strengthOption.AddToChildren(new SsmlOption("x-weak"));
                strengthOption.AddToChildren(new SsmlOption("weak"));
                strengthOption.AddToChildren(new SsmlOption("medium"));
                strengthOption.AddToChildren(new SsmlOption("strong"));
                strengthOption.AddToChildren(new SsmlOption("x-strong"));

                SsmlOption timeOption = new SsmlOption("time");
                timeOption.AddToChildren(new SsmlOption("500ms"));
                timeOption.AddToChildren(new SsmlOption("1000ms"));
                timeOption.AddToChildren(new SsmlOption("1500ms"));
                timeOption.AddToChildren(new SsmlOption("2000ms"));


                breakOption.AddToChildren(strengthOption);
                breakOption.AddToChildren(timeOption);

                this.options.Add(breakOption);
            }
            /*
            {
                SsmlOption prosodyOption = new SsmlOption("prosody", "Prosody (pitch, rate, volume, duration, contour)", OptionType.Wrap);

                SsmlOption pitchOption = new SsmlOption("pitch");
                pitchOption.AddToChildren(new SsmlOption("x-weak"));
                pitchOption.AddToChildren(new SsmlOption("weak"));
                pitchOption.AddToChildren(new SsmlOption("medium"));
                pitchOption.AddToChildren(new SsmlOption("strong"));
                pitchOption.AddToChildren(new SsmlOption("x-strong"));



                prosodyOption.AddToChildren(pitchOption);
                prosodyOption.AddToChildren(timeOption);

                this.options.Add(prosodyOption);
            }*/
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ResetOptions();
            }
        }

        private void HandleDoubleClick(object sender, EventArgs e)
        {
            SsmlOption selectedOption = null;
            
            foreach (SsmlOption option in GetActiveOptions())
            {
                if(listBox.SelectedItem == option.text)
                {
                    selectedOption = option;
                    break;
                }
            }

            if( selectedOption == null) { return; }

            resetButton.Visible = true;
            HandleSelectNewOption(selectedOption);
        }

        private void HandleSelectNewOption(SsmlOption option)
        {
            trackUserOptions.Add(option.text);

            if( option.isFinalOption())
            {
                var tags = option.GetTags();
                
                var wrapStart = textToRead.SelectionStart;
                var wrapEnd = textToRead.SelectionStart + textToRead.SelectionLength;

                string newText = textToRead.Text;
                newText = newText.Insert(wrapEnd, tags[1]);
                newText = newText.Insert(wrapStart, tags[0]);

                textToRead.Text = newText;
                ResetOptions();
            }

            this.SetItems();
        }

        private void resetSsmlMarkupLangListBox_Click(object sender, EventArgs e)
        {
            trackUserOptions.RemoveAt(trackUserOptions.Count - 1);
            if (trackUserOptions.Count == 1)
            {
                resetButton.Visible = false;
            }
            this.SetItems();
        }

        private void ResetOptions()
        {
            resetButton.Visible = false;
            trackUserOptions.Clear();
            this.SetItems();
        }

        private void SetItems()
        {
            this.listBox.Items.Clear();
            var breadText = "";

            foreach(SsmlOption option in GetActiveOptions())
            {
                this.listBox.Items.Add(option.text);
            }

            for(var it= 0; it< trackUserOptions.Count; it++)
            {
                if (breadText!="") { breadText += " > "; }
                breadText += trackUserOptions[it];
            }
            breadcrumbText.Text = breadText;
        }

        private List<SsmlOption> GetActiveOptions()
        {
            List<SsmlOption> FindChildrenOfItem(List<SsmlOption> targetOptions, string item)
            {
                foreach (SsmlOption option in targetOptions)
                {
                    if (item == option.text)
                    {
                        return option.children;
                    }
                }
                return null;
            }

            var currentOptions = options;
            foreach (string selectedItem in trackUserOptions)
            {
                currentOptions = FindChildrenOfItem(currentOptions, selectedItem);
            }
            return currentOptions;
        }
    }
}
