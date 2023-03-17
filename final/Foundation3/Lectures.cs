public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) : base(title, description, dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"Event Type: Lecture\n{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}