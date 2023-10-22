using System;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that He gave His only begotten Son...");

        scripture.Display();

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