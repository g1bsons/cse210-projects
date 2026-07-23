using System;

public class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        this._eventType = eventType;
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }


    public string GetEventType()
    {
        return _eventType;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public Address GetAddress()
    {
        return _address;
    }

    public string GetDetails()
    {
        string details = "Title: " + _title + "\n";
        details = details + "Description: " + _description + "\n";
        details = details + "Date: " + _date + "\n";
        details = details + "Time: " + _time + "\n";
        details = details + "Address: " + _address.ToString() + "\n";
        return details;
    }

    public string GetFullDetails()
    {
        string details = "Event Type: " + _eventType + "\n";
        details = details + GetDetails();
        return details;
    }

    public string GetDescription()
    {
        string description = _eventType + " - " + _title + " " + _date;
        return description;
    }
}
