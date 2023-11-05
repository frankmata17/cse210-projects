using System;
using System.Threading;

class Activity
{
    protected string name;
    protected string description;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
        
    }

    public void StartActivity(int duration)
    {
        Console.WriteLine($"{name} Activity: {description}");
        Console.Write($"Enter the duration (in seconds) for {name} Activity: {duration} s");

        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\nPrepare to begin...");

        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void EndActivity()
    {
        Console.WriteLine($"Good job! You have completed the {name} Activity.");
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}