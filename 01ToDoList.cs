using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;


public class ToDoList
{
    public static string[] tasks = new string[10]; // ToDoList
    public static int taskCount = 0; // Number of tasks in the ToDoList

    public static void AddTask()
    {
        Console.WriteLine("Enter a task: ");
        tasks[taskCount] = Console.ReadLine();
        taskCount++;
        Console.WriteLine("Task added successfully!");
    }

    public static void ViewTasks()
    {
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i+1) + ". " + tasks[i]);
        }
    }

    public static void CompleteTask() {
        Console.WriteLine("Enter the task number to mark as complete: ");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;
        if (taskNumber >= 0 && taskNumber < taskCount)
        {
            tasks[taskNumber] = null; // Mark the task as complete by setting it to null
            Console.WriteLine("Task marked as complete!");
        } else
        {
            Console.WriteLine("Invalid task number!");
        }
    }

    public static void Main(string[] args) {
        bool running = true; // Indicates if the program is running

        while (running)
        {
            Console.WriteLine("ToDo List Menu:");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark a task as complete");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    AddTask();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:
                    CompleteTask();
                    break;
                case 4:
                    running = false; // Exit the program
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

        }

        Console.WriteLine("Goodbye!");

    }

}