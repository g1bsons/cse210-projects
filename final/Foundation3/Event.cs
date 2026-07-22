using System;

public class Event
{
    private string eventType;
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        this.eventType = eventType;
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }


    public string GetEventType()
    {
        return eventType;
    }
    public string GetTitle()
    {
        return title;
    }
    public string GetDate()
    {
        return date;
    }
    public string GetTime()
    {
        return time;
    }
    public Address GetAddress()
    {
        return address;
    }

    public string GetDetails()
    {
        string details = "Title: " + title + "\n";
        details = details + "Description: " + description + "\n";
        details = details + "Date: " + date + "\n";
        details = details + "Time: " + time + "\n";
        details = details + "Address: " + address.ToString() + "\n";
        return details;
    }

    public string GetFullDetails()
    {
        string details = "Event Type: " +eventType + "\n";
        details = details + GetDetails();
        return details;
    }

    public string GetDescription()
    {
        string description = eventType + " - " + title + " " + date;
        return description;
    }
}
