using System.Text;
using static MorseCode.MorseCodeTranslator;

namespace MorseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            TextToMorseTranslator textToMorseTranslator = new TextToMorseTranslator();
            MorseToTextTranslator morseToTextTranslator = new MorseToTextTranslator();

            while (true)
            {
                Console.WriteLine("Choose the option:");
                Console.WriteLine("1. Text to Morse Code");
                Console.WriteLine("2. Morse Code to Text");
                Console.WriteLine("3. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter text for traslation: ");
                            string inputText = Console.ReadLine();
                            string morseCode = textToMorseTranslator.TranslateToMorse(inputText);
                            Console.WriteLine($"The result is: {morseCode}");
                            break;
                        case 2:
                            Console.Write("Enter the Morse code for traslation: ");
                            string inputMorseCode = Console.ReadLine();
                            string text = morseToTextTranslator.TranslateToText(inputMorseCode);
                            Console.WriteLine($"The result is: {text}");
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Error!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                }

                Console.WriteLine();
            }
        }
    }
}
    
