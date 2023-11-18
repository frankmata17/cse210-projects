enum GoalType
{
    Simple,
    Eternal,
    Checklist
}
class UIManagement
{
    public void DisplayMenu()
    {
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. Record an event for a goal");
        Console.WriteLine("3. Show the list of goals");
        Console.WriteLine("4. Display the user's score");
        Console.WriteLine("5. Save progress");
        Console.WriteLine("6. Load progress");
        Console.WriteLine("7. Exit");
        Console.Write("Enter your choice: ");
    }

    public Goal CreateNewGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        GoalType goalType = (GoalType)int.Parse(Console.ReadLine());

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        switch (goalType)
        {
            case GoalType.Simple:
                Console.Write("Enter the point value: ");
                int points = int.Parse(Console.ReadLine());
                return new SimpleGoal(name, description, points);
            case GoalType.Eternal:
                // You might have specific logic for EternalGoal creation
                return new EternalGoal(name, description);
            case GoalType.Checklist:
                Console.Write("Enter the point value: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the completion threshold: ");
                int threshold = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                return new ChecklistGoal(name, description, checklistPoints, threshold, bonus);
            default:
                Console.WriteLine("Invalid goal type. Creating a simple goal by default.");
                Console.Write("Enter the point value: ");
                int defaultPoints = int.Parse(Console.ReadLine());
                return new SimpleGoal(name, description, defaultPoints);
        }
    }

    public void ShowGoals(List<Goal> goals)
    {
        // Implement your logic for displaying goals here
    }

    public void RecordEvent(Goal goal)
    {
        // Implement your logic for recording events here
    }

    public void DisplayScore(List<Goal> goals)
    {
        // Implement your logic for displaying the user's score here
    }

    public void SaveProgress(List<Goal> goals)
    {
        // Implement your logic for saving progress here
    }

    public List<Goal> LoadProgress()
    {
        // Implement your logic for loading progress here
        return new List<Goal>();
    }
}