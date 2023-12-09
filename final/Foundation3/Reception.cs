class ReceptionEvent : Event
{
    private string rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
