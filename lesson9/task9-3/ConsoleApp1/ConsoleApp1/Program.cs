

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        string result = input.Replace(" ", "");

        Console.WriteLine("Result:");
        Console.WriteLine(result);
    }
}
