
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered the number: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: not a number!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unknown error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Exit program.");
        }
    }
}
