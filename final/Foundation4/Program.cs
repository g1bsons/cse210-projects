using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running("06/28/2002", 100, 16);
        Cycling cycling1 = new Cycling("12/17/2009", 180, 40);
        Swimming swimming1 = new Swimming("11/01/2008", 60, 50);

        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);

        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine(activities[i].GetSummary());
        }
    }
}