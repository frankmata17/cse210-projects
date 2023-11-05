class Reflection : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
    };

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void PerformReflectionActivity(int duration)
    {
        StartActivity(duration);

        for (int i = 0; i < duration; i++)
        {
            string randomPrompt = prompts[new Random().Next(prompts.Count)];
            Console.WriteLine(randomPrompt);

            for (int j = 0; j < 3; j++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            foreach (var question in questions)
            {
                Console.WriteLine(question);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
            }
        }

        EndActivity();
    }
}