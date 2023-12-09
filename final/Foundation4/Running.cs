class Running : Activity
{
    private double distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Running ({minutes} min) - Distance {distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}