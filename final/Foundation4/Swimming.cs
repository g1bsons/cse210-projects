using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double lengthMinutes, int laps)
        :base("Swimming", date, lengthMinutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000.0 * 0.62;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLengthMinutes()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = GetLengthMinutes() / GetDistance();
        return pace;
    }
}