public class OutdoorGatherings : Event
{
    private string _weather;
    public OutdoorGatherings(string title, string description, DateTime dateTime, Address address, string weather) : base(title, description, dateTime, address)
    {
        _weather = weather;
    }
    public override string GetFullDetails()
    {
        return $"Event Type:Outdoor Gathering\n{GetStandardDetails()}\nWeather Forcast: {_weather}";
    }
    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {base.GetTitle()}\nDate: {base.GetDateTime()}";
    }

}
