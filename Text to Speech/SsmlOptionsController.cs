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
        TextBox textBox;
        Button resetButton;
        List<SsmlOption> options = new List<SsmlOption>();
        List<SsmlOption> activeOptions = new List<SsmlOption>();

        public SsmlOptionsController(Button resetButton, ListBox listBox, TextBox textBox)
        {
            this.listBox = listBox;
            this.textBox = textBox;
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
                SsmlOption breakOption = new SsmlOption();
                breakOption.text = "Break";

                SsmlOption strengthOption = new SsmlOption();
                strengthOption.text = "strength";


                SsmlOption strengthSubOption1 = new SsmlOption();
                strengthSubOption1.text = "x-weak";
                strengthSubOption1.optionType = OptionType.Insert;

                SsmlOption strengthSubOption2 = new SsmlOption();
                strengthSubOption2.text = "x-strong";
                strengthSubOption2.optionType = OptionType.Insert;

                strengthOption.children.Add(strengthSubOption1);
                strengthOption.children.Add(strengthSubOption2);


                breakOption.children.Add(strengthOption);
                
                this.options.Add(breakOption);
            }

            this.activeOptions = this.options;
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.ResetOptions();
            }
        }

        private void HandleDoubleClick(object sender, EventArgs e)
        {
            resetButton.Visible = true;

            foreach (SsmlOption option in this.activeOptions)
            {
                if(listBox.SelectedItem == option.text)
                {
                    activeOptions = option.children;
                }
            }
            this.SetItems();
        }

        private void resetSsmlMarkupLangListBox_Click(object sender, EventArgs e)
        {
            this.ResetOptions();
        }

        private void ResetOptions()
        {
            resetButton.Visible = false;
            activeOptions = options;
            this.SetItems();
        }

        private void SetItems()
        {
            this.listBox.Items.Clear();

            foreach(SsmlOption option in this.activeOptions)
            {
                this.listBox.Items.Add(option.text);
            }
        }

    }
}
