using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Text_to_Speech
{
    enum SelectableTextState
    {
        OnlySelectedDisplayed,
        None,
    }

    class SelectableText
    {
        private TextBox textBox;
        private Label textBoxLabel;
        private string originalText = ""; // 
        private string initSelectedText = ""; // keeps text which was originally selected
        private SelectableTextState state = SelectableTextState.None;
        private int selectionLength, selectionStart;

        private Color isolationBackColor = SystemColors.InactiveCaptionText;
        private Color isolationForeColor = SystemColors.ControlLightLight;

        private Color defaultBackColor = Color.White;
        private Color defaultForeColor = SystemColors.WindowText;


        public SelectableText(TextBox textBox, Label textBoxLabel)
        {
            this.textBox = textBox;
            this.textBoxLabel = textBoxLabel;
            InitValues();
        }

        public bool IsolateSelectedText()
        {
            if (textBox.SelectionLength > 0)
            {
                originalText = textBox.Text;
                selectionStart = textBox.SelectionStart;
                selectionLength = textBox.SelectionLength;
                initSelectedText = textBox.Text = textBox.SelectedText;

                IsolationListener();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void IsolationListener()
        {
            state = SelectableTextState.OnlySelectedDisplayed;
            textBox.BackColor = isolationBackColor;
            textBox.ForeColor= isolationForeColor;
            textBoxLabel.Text += " (Isolated mode ON)";
        }

        public bool IsSelectedDisplayedOnly()
        {
            return state == SelectableTextState.OnlySelectedDisplayed;
        }

        public void DisplayOriginal()
        {
            if (state != SelectableTextState.OnlySelectedDisplayed) { return; }

            string textToSet = originalText;

            if (textBox.Text != initSelectedText)
            {
                var confirmResult = MessageBox.Show("Do you want to apply changes?", "Apply changes", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    textToSet = textToSet.Remove(selectionStart, selectionLength);
                    textToSet = textToSet.Insert(selectionStart, textBox.Text);
                    selectionLength = textBox.Text.Length;
                }
            }
            textBox.Text = textToSet;
            textBox.Select(selectionStart, selectionLength);

            InitValues();
        }

        private void InitValues()
        {
            state = SelectableTextState.None;
            initSelectedText = originalText = "";

            textBoxLabel.Text = textBoxLabel.Text.Replace(" (Isolated mode ON)", "");

            textBox.BackColor = defaultBackColor;
            textBox.ForeColor = defaultForeColor;
        }
    }
}
