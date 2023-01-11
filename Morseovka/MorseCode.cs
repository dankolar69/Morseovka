using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morseovka
{
    internal class MorseCode
    {
        private Dictionary<char, string> _encodeDict = new Dictionary<char, string>()
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
        {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
        {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
        {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
        {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
        {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
        {'Y', "-.--"}, {'Z', "--.."},

    };

        private Dictionary<string, char> _decodeDict;

        public MorseCode()
        {
            _decodeDict = _encodeDict.ToDictionary(x => x.Value, x => x.Key);
        }

        public string Encode(string text)
        {
            text = text.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (_encodeDict.ContainsKey(c))
                {
                    result.Append(_encodeDict[c]);
                    result.Append(" ");
                }
            }
            return result.ToString().Trim();
        }

        public string Decode(string code)
        {
            string result = "";



            code = code.Trim();
            string[] words = code.Split(' ');



            foreach (string word in words)
            {
                if (_decodeDict.ContainsKey(word))
                {
                    result += _decodeDict[word];
                }
            }



            return result;
        }
    }
}
