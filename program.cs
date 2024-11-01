//TODO LIST

using System;
using System.Collections.Generic;

bool appRunning = true;
List<string> tasks = new List<string>();

while (appRunning)
{
    Console.WriteLine("Type:");
    Console.WriteLine("For Adding Tasks - 1");
    Console.WriteLine("For Deleting Tasks - 2");
    Console.WriteLine("For Marking Tasks as Completed - 3");
    Console.WriteLine("For seeing all Tasks - 4");

    static void Empty()
    {
        Console.WriteLine();
    }

    char action = Convert.ToChar(Console.ReadLine());

    switch (action)
    {
        case '1':
            Console.Write("[ADD] Add Task Name: ");
            string addTask = Console.ReadLine();
            tasks.Add(addTask);
            Empty();

            Console.WriteLine("Tasks:");
            Empty();
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            Empty();
            break;

        case '2':
            Console.Write("[DELETE] Add Task Name: ");
            string removeTask = Console.ReadLine();
            tasks.Remove(removeTask);
            Empty();

            Console.WriteLine("Tasks:");
            Empty();
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            Empty();
            break;

        case '3':
            Console.Write("[DONE] Add Task Name: ");
            string finishTask = Console.ReadLine();
            tasks.Remove(finishTask);
            Empty();

            Console.WriteLine("Tasks:");
            Empty();
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            Empty();
            break;
        case '4':
            Console.WriteLine("Tasks:");
            Empty();
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            Empty();
            break;
    }

    Console.Write("Do you want to see again [Y/N]: ");
    string response = Console.ReadLine().ToUpper();

    if (response != "Y")
    {
        appRunning = false;
        Empty();
    }
}
