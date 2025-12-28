

using System;
using System.Text;

class Program
{
    static void Main()
    {
        // creating StringBuilder
        StringBuilder report = new StringBuilder();

        // Header
        report.AppendLine("=== TEXT REPORT ===");

        // Data
        report.AppendLine($"Date: {DateTime.Now}");
        report.AppendLine();

        // Event list
        report.AppendLine("Events:");

        while (true)
        {
            Console.Write("Enter event (or 'exit' to finish): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            report.AppendLine("- " + input);
        }

        // output result
        Console.WriteLine();
        Console.WriteLine("===== FINAL REPORT =====");
        Console.WriteLine(report.ToString());
    }
}