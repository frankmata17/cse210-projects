using System;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        UIManagement ui = new UIManagement();

        while (true)
        {
            Console.Clear(); // Clear the console for a cleaner display

            ui.DisplayMenu();

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Goal newGoal = ui.CreateNewGoal();
                        if (newGoal != null)
                        {
                            goals.Add(newGoal);
                            Console.WriteLine("Goal created successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid goal type. Please try again.");
                        }
                        break;
                    case 2:
                        ui.ShowGoals(goals);
                        Console.WriteLine("Enter the index of the goal you want to record an event for:");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            if (index >= 0 && index < goals.Count)
                            {
                                ui.RecordEvent(goals[index]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index. Please try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case 3:
                        ui.ShowGoals(goals);
                        break;
                    case 4:
                        ui.DisplayScore(goals);
                        break;
                    case 5:
                        ui.SaveProgress(goals);
                        break;
                    case 6:
                        goals = ui.LoadProgress();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}