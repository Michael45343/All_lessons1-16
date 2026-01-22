
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = a / b;
            Console.WriteLine("Division result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: division by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: incorrect number!");
        }
        finally
        {
            Console.WriteLine("Exit program.");
        }
    }
}
