using System;

class Program
{
    static void Main()
    {
        // Create a Scripture object
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that He gave His only begotten Son...");

        // Display the initial scripture
        scripture.Display();

        // Continue hiding words until all are hidden
        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            bool wordHidden = scripture.HideRandomWord();

            if (wordHidden)
            {
                Console.Clear();
                scripture.Display();
            }
            else
            {
                Console.WriteLine("All words are already hidden.");
            }
        }
    }
}