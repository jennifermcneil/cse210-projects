using System;
public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }
    public string GetDateTime()
    {
        return _dateTime.ToString("MM/dd/yyyy hh:mm tt");
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetStandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate & Time: {_dateTime.ToString("MM/dd/yyyy hh:mm tt")}\nAddress: {_address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}

//Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.

//They would like the ability to generate three different messages:

//Standard details - Lists the title, description, date, time, and address.
//Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
//Short description - Lists the type of event, title, and the date.