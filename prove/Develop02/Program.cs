using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool exit = false; // Add a flag to control the loop

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Write a new entry with a random prompt
                    Random random = new Random();
                    int randomIndex = random.Next(prompts.Count);
                    string randomPrompt = prompts[randomIndex];

                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        Prompt = randomPrompt,
                        Response = response,
                        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") // You can use any format you prefer
                    };

                    journal.AddEntry(newEntry);
                    break;

                case 2:
                    journal.DisplayEntries();
                    break;

                case 3:
                    Console.Write("Enter file name to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case 4:
                    Console.Write("Enter file name to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case 5:
                    exit = true; // Set the flag to exit the loop
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}