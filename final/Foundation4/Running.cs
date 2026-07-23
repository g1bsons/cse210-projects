using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double lengthMinutes, double distance)
        :base("Running", date, lengthMinutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (_distance / GetLengthMinutes()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = GetLengthMinutes() / _distance;
        return pace;
    }
}