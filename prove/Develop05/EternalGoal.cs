using System;

public class EternalGoal : Goal
{
    // this is the constructor
    public EternalGoal(string name, int points) : base(name, points)
    {}


    // use the abstract method from 'Goal' to override 'RecordEvent'
    public override int RecordEvent()
    {
        return GetPoints();
    }

    // uses the abstract method from 'Goal' to override 'GetDetails'
    public override string GetDetails()
    {
        return "[ ] " + GetName();
    }

    // uses the abstract method from 'Goal' to override 'SaveString'
    public override string SaveString()
    {
        return "EternalGoal:" + GetName() + ":" + GetPoints();   
    }
}