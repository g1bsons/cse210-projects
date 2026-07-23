using System;

public class Activity
{
    private string _name;
    private string _date;
    private double _lengthMinutes;

    public Activity(string name,string date, double lengthMinutes)
    {
        this._name = name;
        this._date = date;
        this._lengthMinutes = lengthMinutes;
    }


    public string GetName()
    {
        return _name;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetLengthMinutes()
    {
        return _lengthMinutes;
    }


    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }


    public virtual string GetSummary()
    {
        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);

        string summary = _date + " " + _name + " (" + _lengthMinutes + " min) - ";
        summary = summary + "Distance " + distance + " miles, ";
        summary = summary + "Speed " + speed + " mph, ";
        summary = summary + "Pace: " + pace + " min per mile";
        return summary;
    }
}