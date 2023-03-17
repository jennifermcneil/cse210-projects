public class Receptions : Event
{
    private string _rsvpEmail;
    public Receptions(string title, string description, DateTime dateTime, Address address, string rsvpEmail) : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        return $"Event Type: Reception\n{GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }


}
