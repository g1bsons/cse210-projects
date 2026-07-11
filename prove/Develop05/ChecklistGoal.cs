using System;

public class ChecklistGoal : Goal
{
    // new variables specifically for this class 
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;


    // this is our lovely constructor
    public ChecklistGoal(string name, int points, int targetAmount, int bonusPoints) : base(name, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }


    // uses the abstract method from 'Goal' to override 'RecordEvent'
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        _amountCompleted = _amountCompleted + 1;
        int pointsEarned = GetPoints();

        if (_amountCompleted >= _targetAmount)
        {
            SetComplete(true);
            pointsEarned = pointsEarned + _bonusPoints;
        }
        return pointsEarned;
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
        return mark + " " + GetName() + " Completed " + _amountCompleted + "/" + _targetAmount + " times";

    }

    // uses the abstract method from 'Goal' to override 'SaveString'
    public override string SaveString()
    {
        return "ChecklistGoal:" + GetName() + ":" + GetPoints() + ":" + _targetAmount + ":" + _bonusPoints + ":" + _amountCompleted;
    }
}