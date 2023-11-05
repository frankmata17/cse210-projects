class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void PerformBreathingActivity(int duration)
    {
        StartActivity(duration);

        for (int i = 0; i < duration; i++)
        {
            Console.Write("Breathe in...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("Breathe out...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        EndActivity();
    }
}