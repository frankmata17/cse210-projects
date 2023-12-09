class Activity
{
    protected string date;
    protected int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0; // Base class default implementation
    }

    public virtual double GetSpeed()
    {
        return 0.0; // Base class default implementation
    }

    public virtual double GetPace()
    {
        return 0.0; // Base class default implementation
    }

    public virtual string GetSummary()
    {
        return $"{date} - Unknown Activity ({minutes} min)";
    }
}