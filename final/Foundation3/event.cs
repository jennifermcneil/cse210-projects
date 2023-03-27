using System;
public class Event
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

    public virtual string GetFullDetails()
    {
        return "";
    }
    public string GetShortDescription()
    {
        return $"{this.GetType()}: {_title} @ {GetDateTime()}";
    }
}

