class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming ({minutes} min) - Distance {GetDistance():F2} km, Speed {GetSpeed()} kph, Pace: {GetPace():F2} min per km";
    }
}