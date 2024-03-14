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
                bool correctGuess = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                    {
                        displayWord = displayWord.Remove(i, 1).Insert(i, guess.ToString());
                        correctGuess = true;
                    }
                }
                if (!correctGuess)
                {
                    tries++
                    DrawHangMan(tries);
                }

                Console.WriteLine($"\n    {displayWord}\n");

                if (displayWord == word || tries >= 3)
                    done = true;
            }

            if (displayWord == word)
                Console.WriteLine("Congratulations! You've guessed the word.");
            else
                Console.WriteLine($"Sorry, you've used up all your tries. The word was {word}.");

            Console.ReadLine();
        }
            static void DrawHangMan()
            {
                switch (tries)
                {
                    case 1:
                        hangmanOne();
                        break;
                    case 2:
                        hangmanTwo();
                        break;
                    case 3:
                        hangmanThree();
                        break;
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
        }
    }

}