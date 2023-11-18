class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int completionThreshold;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int threshold, int bonus) : base(name, description)
    {
        timesCompleted = 0;
        completionThreshold = threshold;
        bonusPoints = bonus;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        timesCompleted++;

        if (timesCompleted == completionThreshold)
        {
            Points += bonusPoints;
            Console.WriteLine($"Bonus: {bonusPoints} points for completing the checklist!");
        }
    }

    public override bool IsGoalComplete()
    {
        return timesCompleted == completionThreshold;
    }

    public override string GetGoalStatus()
    {
        return $"{base.GetGoalStatus()} Completed {timesCompleted}/{completionThreshold} times";
    }
}