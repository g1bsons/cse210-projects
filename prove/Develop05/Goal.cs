using System;

public abstract class Goal
{
    //these are the variables
    private string _name;
    private int _points;
    private bool _isComplete;


    //this is the constructor
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }


    //these are the getters
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

}