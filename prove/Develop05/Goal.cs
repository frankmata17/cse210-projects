class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; internal set; } // internal or protected internal
    public bool IsComplete { get; internal set; } // internal or protected internal

    public Goal(string name, string description)
    {
        Name = name;
        Description = description;
        Points = 0;
        IsComplete = false;
    }

    public virtual void RecordEvent()
    {
        IsComplete = true;
    }

    public virtual bool IsGoalComplete()
    {
        return IsComplete;
    }

    public virtual string GetGoalStatus()
    {
        return IsComplete ? "[X]" : "[ ]";
    }
}