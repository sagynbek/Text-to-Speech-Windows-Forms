using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private string originalText = "";
        private SelectableTextState state = SelectableTextState.None;
        private int selectionLength, selectionStart;

        public SelectableText(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public bool SelectActiveText()
        {
            if (textBox.SelectionLength > 0)
            {
                originalText = textBox.Text;
                selectionStart = textBox.SelectionStart;
                selectionLength = textBox.SelectionLength;
                textBox.Text = textBox.SelectedText;

                state = SelectableTextState.OnlySelectedDisplayed;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSelectedDisplayedOnly()
        {
            return state == SelectableTextState.OnlySelectedDisplayed;
        }

        public void DisplayOriginal()
        {
            if(state != SelectableTextState.OnlySelectedDisplayed) { return; }

            state = SelectableTextState.None;
            textBox.Text = originalText;
            textBox.Select(selectionStart, selectionLength);
            originalText = "";
        }
    }
}
