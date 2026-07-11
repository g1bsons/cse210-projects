using System;

public class SimpleGoal : Goal
{
    // constructor
    public SimpleGoal(string name, int points) : base(name, points)
    {}


    // uses the abstract method from 'Goal' to orcerride 'RecordEvent'
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        SetComplete(true);
        return GetPoints();

    }

    // uses the abstract method from 'Goal' to override 'GetDetails'
    public override string GetDetails()
    {
        string mark;
        if (IsComplete())
        {
            mark = "[X]";
        }
        else
        {
            mark = "[ ]";
        }
        return mark + " " + GetName();
    }

    // uses the abstract method from 'Goal' to override 'SaveString'
    public override string SaveString()
    {
        return "SimpleGoal:" + GetName() + ":" + GetPoints() + ":" + IsComplete();
    }
}