using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morseovka
{
    internal class MorseCode
    {
        private Dictionary<char, string> _MorseDict = new Dictionary<char, string>()
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
        {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
        {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
        {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
        {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
        {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
        {'Y', "-.--"}, {'Z', "--.."},

         {'0', "-----"}, {'1', ".----"}, {'2', "..---"},
        {'3', "...--"}, {'4', "....-"}, {'5', "....."},
        {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
        {'9', "----."},

    };

        private Dictionary<string, char> _textDict;

        public MorseCode()
        {
            _textDict = _MorseDict.ToDictionary(x => x.Value, x => x.Key);
        }

        public string ToMorseCode(string text)
        {
            text = text.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (_MorseDict.ContainsKey(c))
                {
                    result.Append(_MorseDict[c]);
                    result.Append(" ");
                }
            }
            return result.ToString();
        }

        public string ToText(string code)
        {
            string result = "";



            
            string[] words = code.Split(' ');



            foreach (string word in words)
            {
                if (_textDict.ContainsKey(word))
                {
                    result += _textDict[word];
                }
            }



            return result;
        }
    }
}
