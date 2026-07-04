using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("\n=== To-Do List - Negin ===");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Show tasks");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter task: ");
                string task = Console.ReadLine();
                tasks.Add(task);
                Console.WriteLine("Task added!");
            }
            else if (choice == "2")
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks yet!");
                }
                else
                {
                    Console.WriteLine("\nYour tasks:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter task number to delete: ");

                if (int.TryParse(Console.ReadLine(), out int num) &&
                    num > 0 && num <= tasks.Count)
                {
                    tasks.RemoveAt(num - 1);
                    Console.WriteLine("Task deleted!");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }

        Console.WriteLine("Goodbye!");
    }
}