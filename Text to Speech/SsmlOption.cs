using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_to_Speech
{
    enum OptionType
    {
        None,
        Insert,
        Wrap
    }

    class SsmlOption
    {
        public List<SsmlOption> children = new List<SsmlOption>();
        public SsmlOption parent = null;
        public string text;
        public OptionType optionType = OptionType.None;

        public SsmlOption(string text, OptionType optionType = OptionType.None)
        {
            this.text = text;
            this.optionType = optionType;
        }
        public void AddToChildren(SsmlOption child)
        {
            this.children.Add(child);
            child.parent = this;
        }
    }
}
