class OutdoorGatheringEvent : Event
{
    private string _weatherStatement;

    public OutdoorGatheringEvent(string title, string description, DateTime date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}";
    }
}