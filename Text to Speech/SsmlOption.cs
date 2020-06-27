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
        public string tag;
        public OptionType optionType = OptionType.None;

        public SsmlOption(string tag, string text = null, OptionType optionType = OptionType.None)
        {
            this.tag = tag;
            this.text = text==null? tag:text;
            this.optionType = optionType;
        }
        public void AddToChildren(SsmlOption child)
        {
            this.children.Add(child);
            child.parent = this;
        }

        public List<string> GetTags()
        {
            string openingTag = "";
            string closeTag = "";

            List<SsmlOption> allParents = new List<SsmlOption>();
            allParents.Add(this);
            while (allParents[0].parent != null) {
                var parent = allParents[0].parent;
                allParents.Insert(0, parent);
            }

            if (allParents.Count == 3)
            {
                openingTag = $" <{allParents[0].tag} {allParents[1].tag}='{allParents[2].tag}'";
                if(allParents[0].optionType == OptionType.Insert)
                {
                    openingTag += "/> ";
                }
                else
                {
                    openingTag += "> ";
                    closeTag = $" </{allParents[0].tag}> ";
                }
            }

            List<string> result = new List<string>();
            result.Add(openingTag);
            result.Add(closeTag);

            return result;
        }

        public bool isFinalOption()
        {
            return children.Count == 0;
        }
    }
}
