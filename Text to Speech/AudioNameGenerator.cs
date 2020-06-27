using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_to_Speech
{
    class AudioNameGenerator
    {
        private TextBox fileNameTxt;
        List<string> savedFileNames;

        public AudioNameGenerator(TextBox fileNameTxt)
        {
            this.fileNameTxt = fileNameTxt;
            savedFileNames = new List<string>();
        }

        public string GetFileName()
        {
            var audioName = fileNameTxt.Text.Length>0? fileNameTxt.Text:"Audio";
            for(var it=0;true ;it++)
            {
                var newName = audioName + (it > 0 ? it.ToString() : "");
                if (!savedFileNames.Contains(newName))
                {
                    audioName = newName;
                    break;
                }
            }

            savedFileNames.Add(audioName);
            return audioName;
        }
    }
}
