using System.Data;

namespace hangman_topic_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word, displayWord;
            int tries;
            bool done;
            tries = 0;
            done = false;
            word = "COMPUTER";
            displayWord = "________";

            Console.WriteLine("Welcome to Hangman Lite!\n\nGuess letters to find the secret word. \n\nYou have three tries.\n");

            while (!done)
            {
                Console.WriteLine("Please make your guess:\n");
                char guess = Console.ReadLine()[0];

                

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                    { 
                        displayWord = displayWord.Remove(i, 1).Insert(i, guess.ToString());
                        hangmanOne();
                        Console.WriteLine($"\n    {displayWord}\n");
                    }
                }

            }


            static void hangmanOne()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n         |\r\n         |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanTwo()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n         |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanThree()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n    /|\\  |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanFour()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n    /|\\  |\r\n   / \\  |\r\n         |\r\n   =========");
            }
        }
    }
}