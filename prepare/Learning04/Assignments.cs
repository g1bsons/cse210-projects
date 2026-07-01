using System;

public class Assignments
{
    // Added the attributes as private variables
    private string _studentsName;
    private string _topic;

    // Added the constructor to take in a students name and topic
    public Assignments (string studentsName, string topic)
    {
        _studentsName = studentsName;
        _topic = topic;
    }

    // added these lines from the xample cause theres lots of issues in the code
    public string GetStudentsName()
    {
        return _studentsName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // Added the GetSummary method to return a name and topic with a dash
    public string GetSummary()
    {
        return _studentsName + " - " + _topic;
    }

}