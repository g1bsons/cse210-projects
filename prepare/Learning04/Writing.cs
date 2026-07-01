using System;

// Added math to inherit from Assignments
public class Writing : Assignments
{
    // Added private variable
    private string _title;

    // Wrote the constructor
    public Writing(string studentName, string topic, string title)
    {
        _title = title;
    }

    // Added the getwritinginfo method and have it return the title and by student name
    public string GetWritingInfo()
    {
        string studentsName = GetStudentsName();
        return $"{_title} by {studentsName}";
    }

}