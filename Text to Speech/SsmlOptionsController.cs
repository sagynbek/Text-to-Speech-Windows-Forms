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
                SsmlOption breakOption = new SsmlOption("Break");

                SsmlOption strengthOption = new SsmlOption("strength");

                SsmlOption strengthSubOption1 = new SsmlOption("x-weak", OptionType.Insert);
                SsmlOption strengthSubOption2 = new SsmlOption("x-strong", OptionType.Insert);

                strengthOption.AddToChildren(strengthSubOption1);
                strengthOption.AddToChildren(strengthSubOption2);


                breakOption.AddToChildren(strengthOption);
                
                this.options.Add(breakOption);
            }
        }

        private List<SsmlOption> GetActiveOptions()
        {
            List<SsmlOption> FindChildrenOfItem(List<SsmlOption> targetOptions, string item)
            {
                foreach(SsmlOption option in targetOptions) {
                    if(item == option.text)
                    {
                        return option.children;
                    }
                }
                return null;
            }

            var currentOptions = options;
            foreach(string selectedItem in trackUserOptions)
            {
                currentOptions = FindChildrenOfItem(currentOptions, selectedItem);
            }
            return currentOptions;
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
            resetButton.Visible = true;

            foreach (SsmlOption option in GetActiveOptions())
            {
                if(listBox.SelectedItem == option.text)
                {
                    trackUserOptions.Add(option.text);
                    break;
                }
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

    }
}
