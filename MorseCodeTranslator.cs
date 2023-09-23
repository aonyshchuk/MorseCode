using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    public class MorseCodeTranslator
    {
        public class MorseToTextTranslator
        {
            public Dictionary<string, char> morseCodeDictionary;

            public MorseToTextTranslator()
            {
                InitializeMorseCodeDictionary();
            }

            public void InitializeMorseCodeDictionary()
            {
                morseCodeDictionary = new Dictionary<string, char>
            {
                {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
                {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
                {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
                {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
                {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
                {"--..", 'Z'},
                {"-----", '0'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'}, {"....-", '4'},
                {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'}, {"----.", '9'},
                {" ", ' '} 
            };
            }

            public string TranslateToText(string morseCode)
            {
                string[] words = morseCode.Split('/');
                string text = "";

                foreach (string word in words)
                {
                    string[] letters = word.Trim().Split(' ');
                    foreach (string letter in letters)
                    {
                        if (morseCodeDictionary.ContainsKey(letter))
                        {
                            text += morseCodeDictionary[letter];
                        }
                        else
                        {
                            text += " ";
                        }
                    }
                    text += " "; 
                }

                return text.Trim(); 
            }
        }
    }
}

namespace MorseCode
{
    public class TextToMorseTranslator
    {
        public Dictionary<char, string> morseCodeDictionary;

        public TextToMorseTranslator()
        {
            InitializeMorseCodeDictionary();
        }

        public void InitializeMorseCodeDictionary()
        {
            morseCodeDictionary = new Dictionary<char, string>
            {
                {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
                {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
                {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
                {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
                {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
                {'Z', "--.."},
                {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
                {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
                {' ', " "}, 
            };
        }

        public string TranslateToMorse(string text)
        {
            text = text.ToUpper(); 
            string morseCode = "";

            foreach (char character in text)
            {
                if (morseCodeDictionary.ContainsKey(character))
                {
                    morseCode += morseCodeDictionary[character] + " ";
                }
                else
                {
                    morseCode += " "; 
                }
            }

            return morseCode.Trim(); 
        }
    }
}
