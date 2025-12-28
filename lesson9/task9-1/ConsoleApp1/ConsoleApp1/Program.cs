

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first and last name:");
        string input = Console.ReadLine();
        
        // Split the string by a space
        string[] parts = input.Split(' ');
        Console.WriteLine();

        if (parts.Length < 2)
        {
            Console.WriteLine("Enter first and last name:");
            return;
        }

        string name = parts[0];
        string surname = parts[1];

        // Bring the first letters to the same case
        char firstNameLetter = char.ToLower(name[0]);
        char firstSurnameLetter = char.ToLower(surname[0]);

        if (firstNameLetter == firstSurnameLetter)
        {
            Console.WriteLine("The last name starts with the same letter as the first name.");
        }
        else
        {
            Console.WriteLine("The last name doesn't start with the same letter as the first name.");
        }
    }
}
