using System;

public class Assignments
{
    // Added the attributes as private variables
    private string _studentName;
    private string _topic;

    // Added the constructor to take in a students name and topic
    public Assignments (string studentsName, string topic)
    {
        _studentName = studentsName;
        _topic = topic;
    }

    // added these lines from the xample cause theres lots of issues in the code
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // Added the GetSummary method to return a name and topic with a dash
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

}