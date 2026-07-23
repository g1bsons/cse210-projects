using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        :base("Outdoor Gathering", title, description, date, time, address)
    {
        this._weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details = details + "Weather: " + _weather + "\n";
        return details;
    }
}
