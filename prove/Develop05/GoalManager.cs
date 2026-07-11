using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // more class specific variables 
    private List<Goal> _goals;
    private int _score;


    // this si the constructor for this class
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    // this is a new method for this class specifically
    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // another new method
    public void DisplayScore()
    {
        Console.WriteLine("You have " + _score + " points.");
    }

    // another new method
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You dont have any goals right now.");
            return;
        }

        for (int i = 0; i < _goals.Count; i ++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetDetails());
        }
    }

    // this method calls 'RecordEvent' from 'Goal'
    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("This is not a valid goal number.");
            return;
        }

        int pointsEarned = _goals[index].RecordEvent();
        _score = _score + pointsEarned;

        Console.WriteLine("Congrats, you esrned " + pointsEarned + " points!");
    }








    public void SaveGoals(string filename)
    {
        // build up a list of lines first, then write them all at once
        List<string> lines = new List<string>();

        lines.Add(_score.ToString());

        for (int i = 0; i < _goals.Count; i++)
        {
            lines.Add(_goals[i].SaveString());
        }

        File.WriteAllLines(filename, lines);

        Console.WriteLine("Your goals have been saved.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                int points = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);

                SimpleGoal goal = new SimpleGoal(name, points);
                if (isComplete)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                int points = int.Parse(parts[2]);
                _goals.Add(new EternalGoal(name, points));
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                int points = int.Parse(parts[2]);
                int targetAmount = int.Parse(parts[3]);
                int bonusPoints = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);

                ChecklistGoal goal = new ChecklistGoal(name, points, targetAmount, bonusPoints);
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Your goals have been loaded.");
    }
}