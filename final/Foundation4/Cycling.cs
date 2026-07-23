using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double lengthMinutes, double speed)
        :base("Cycling", date, lengthMinutes)
    {
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        double distance = (_speed / 60) * GetLengthMinutes();
        return distance;
    }
    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}