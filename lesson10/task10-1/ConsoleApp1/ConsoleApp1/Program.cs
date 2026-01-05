

using System;
using System.Text;

class Program
{
    static void Main()
    {
        bool playAgain;

        do
        {
            Console.Clear();
            PlayGame();

            Console.WriteLine("\nPlay again? (yes / no)");
            string answer = Console.ReadLine().ToLower();
            playAgain = answer == "yes";

        } while (playAgain);
    }

    static void PlayGame()
    {
        // Word array
        string[] words =
        {
            "cat", "dog", "house", "garden",
            "window", "sea", "book", "sun",
            "whale", "car", "apple", "tree"
        };

        // Selecting the game difficulty
        Console.WriteLine("Select the difficulty:");
        Console.WriteLine("1 - Low (up to 4 letters)");
        Console.WriteLine("2 - Medium (up to 6 letters)");
        Console.WriteLine("3 - Hard (up to 8 letters)");

        int difficulty;
        while (!int.TryParse(Console.ReadLine(), out difficulty) || difficulty < 1 || difficulty > 3)
        {
            Console.WriteLine("Enter 1, 2, 3");
        }

        int maxLength = difficulty == 1 ? 4 : difficulty == 2 ? 6 : 8;

        // Generating a random word
        Random rnd = new Random();
        string secretWord;

        do
        {
            secretWord = words[rnd.Next(words.Length)];
        }
        while (secretWord.Length > maxLength);

        char[] hiddenWord = new char[secretWord.Length];
        for (int i = 0; i < hiddenWord.Length; i++)
            hiddenWord[i] = '_';

        int attemptsLeft = 6;
        bool[] guessedLetters = new bool[secretWord.Length];

        Console.Clear();
        Console.WriteLine("Try to guess the word!");
        Console.WriteLine($"Number of letters in a word: {secretWord.Length}");
        Console.WriteLine($"Number of errors: {attemptsLeft}\n");

        // Basic game
        while (attemptsLeft > 0)
        {
            Console.WriteLine("Word: " + string.Join(" ", hiddenWord));
            Console.Write("\nEnter your letter: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrEmpty(input) || input.Length != 1)
            {
                Console.WriteLine("Enter ONE letter!");
                continue;
            }

            char letter = input[0];
            bool found = false;
            StringBuilder positions = new StringBuilder();

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter && hiddenWord[i] == '_')
                {
                    hiddenWord[i] = letter;
                    found = true;
                    positions.Append((i + 1) + ",");
                }
            }

            if (found)
            {
                positions.Length--; // Removing the last comma
                Console.WriteLine($"It have the letter! Letter position: {positions}");
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine($"It doesn't have the letter! Attempts left: {attemptsLeft}");
            }

            // Victory checking
            if (!new string(hiddenWord).Contains("_"))
            {
                Console.WriteLine($"\nCongrats! That's the right word.");
                Console.WriteLine($"Secret word was: {secretWord}");
                return;
            }

            Console.WriteLine();
        }

        // Lose
        Console.WriteLine("\nYou lose!");
        Console.WriteLine($"Secret word was" +
            $": {secretWord}");
    }
}