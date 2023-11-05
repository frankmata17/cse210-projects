using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        Listing listingActivity = new Listing();

        int selectedActivity;
        do
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            selectedActivity = int.Parse(Console.ReadLine());

            switch (selectedActivity)
            {
                case 1:
                    breathingActivity.PerformBreathingActivity(300); // Example duration (in seconds)
                    break;
                case 2:
                    reflectionActivity.PerformReflectionActivity(300); // Example duration (in seconds)
                    break;
                case 3:
                    listingActivity.PerformListingActivity(300); // Example duration (in seconds)
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid activity.");
                    break;
            }
        } while (selectedActivity != 4);
    }
}