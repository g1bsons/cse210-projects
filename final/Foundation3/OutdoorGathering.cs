using System;

public class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        :base("Outdoor Gathering", title, description, date, time, address)
    {
        this.weather = weather;
    }

    public string GetWeather()
    {
        return weather;
    }

    public string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details = details + "Weather: " + weather + "\n";
        return details;
    }
}
