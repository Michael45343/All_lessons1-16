
using System;
using System.IO;


////task15

class Program 
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your path to data file: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Enter your path to copy file: ");
            string destinationPath = Console.ReadLine();

            // Reading the text from data file
            string content = File.ReadAllText(sourcePath);

            // Rewriting the text to the new file
            File.WriteAllText(destinationPath, content);

            Console.WriteLine("The file was copied!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
