class Listing : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
    };

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void PerformListingActivity(int duration)
    {
        StartActivity(duration);

        string randomPrompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(randomPrompt);

        Thread.Sleep(3000);

        List<string> itemsList = new List<string>();
        Console.WriteLine("Start listing items. Press Enter after each item.");

        while (true)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;

            itemsList.Add(item);
        }

        Console.WriteLine($"You listed {itemsList.Count} items.");
        EndActivity();
    }
}