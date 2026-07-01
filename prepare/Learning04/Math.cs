using System;

// Added math to inherit from Assignments
public class Math : Assignments
{
    // Added the attributes as private variables
    private string _textbookSection;
    private string _problems;

    // Created the constructor for all 4 parameters
    public Math(string studentName, string topic, string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Added a Gethomework method to return the hw assignments
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }

}