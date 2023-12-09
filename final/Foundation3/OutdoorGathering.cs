class OutdoorGatheringEvent : Event
{
    private string weather;

    public OutdoorGatheringEvent(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}