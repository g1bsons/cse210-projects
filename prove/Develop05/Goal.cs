using System;

public abstract class Goal
{
    // these are the variables
    private string _name;
    private int _points;
    private bool _isComplete;


    // this is the constructor
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }


    // these are the getters
    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }


    // this is the setter
    protected void SetComplete(bool value)
    {
        _isComplete = value;
    }


    // these are the abstract methods
    // meaning they have no specified implementation here
    public abstract int RecordEvent();
    public abstract string GetDetails();
    public abstract string SaveString();

}