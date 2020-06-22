using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Text_to_Speech
{
    class SsmlConverter
    {
        /**
         * For more information about markup languages:
         * https://docs.microsoft.com/en-us/cortana/skills/speech-synthesis-markup-language
         * */
        // 
        // 
        public static string ConvertTextIntoSSML(string text, SpeechSynthesizer speechSynthesizer)
        {
            return WrapText(text, speechSynthesizer);
        }

        private static string WrapText(string text, SpeechSynthesizer speechSynthesizer)
        {
            var voice = speechSynthesizer.Voice;

            string result = "<speak version=\"1.0\"";
            result += " xmlns=\"http://www.w3.org/2001/10/synthesis\"";
            result += " xml:lang=\"" + voice.Culture.Name + "\">";
            result += text;
            result += "</speak>";

            return result;
        }
    }
}
