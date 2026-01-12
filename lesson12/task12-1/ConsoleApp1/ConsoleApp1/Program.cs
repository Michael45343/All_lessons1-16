

using System;

class Program
{
    static string[] tasks = new string[2];
    static bool[] done = new bool[2];
    static int count = 0;

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("TO-DO LIST");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. Show all tasks");
            Console.WriteLine("3. Mark the task completed");
            Console.WriteLine("4. Delete the task");
            Console.WriteLine("5. Show Task Array");
            Console.WriteLine("0. Exit");
            Console.Write("Select: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddTask(); break;
                case "2": ShowTasks(); break;
                case "3": MarkDone(); break;
                case "4": DeleteTask(); break;
                case "5": LoadTasks(); break;
                case "0": return;
                default:
                    Console.WriteLine("Wrong choice!");
                    Pause();
                    break;
            }
        }
    }

    // Adding a task
    static void AddTask()
    {
        Console.Write("Enter the name of the tasks: ");
        string task = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(task))
        {
            Console.WriteLine("The title can't be empty!");
            Pause();
            return;
        }

        if (count == tasks.Length)
        {
            Resize();
        }

        tasks[count] = task;
        done[count] = false;
        count++;

        Console.WriteLine("The task was added");
        Pause();
    }

    // Output all tasks
    static void ShowTasks()
    {
        if (count == 0)
        {
            Console.WriteLine("The list is empty...");
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                string status = done[i] ? "[+]" : "[-]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }
        }
        Pause();
    }

    // Marking the added task
    static void MarkDone()
    {
        ShowTasks();
        if (count == 0) return;

        Console.Write("Task number: ");
        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= count)
        {
            done[index - 1] = true;
            Console.WriteLine("The task was completed!");
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
        Pause();
    }

    // Deleting a task
    static void DeleteTask()
    {
        ShowTasks();
        if (count == 0) return;

        Console.Write("Delete number: ");
        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= count)
        {
            for (int i = index - 1; i < count - 1; i++)
            {
                tasks[i] = tasks[i + 1];
                done[i] = done[i + 1];
            }

            tasks[count - 1] = null;
            done[count - 1] = false;
            count--;

            Console.WriteLine("The task was deleted!");
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
        Pause();
    }

    // Showing the Task Array
    static void LoadTasks()
    {
        Console.WriteLine("Task array:");

        if (count == 0)
        {
            Console.WriteLine("The array is empty!");
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("- " + tasks[i]);
            }
        }
        Pause();
    }

    // Increasing the array
    static void Resize()
    {
        string[] newTasks = new string[tasks.Length * 2];
        bool[] newDone = new bool[done.Length * 2];

        for (int i = 0; i < tasks.Length; i++)
        {
            newTasks[i] = tasks[i];
            newDone[i] = done[i];
        }

        tasks = newTasks;
        done = newDone;
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key...");
        Console.ReadKey();
    }
}
