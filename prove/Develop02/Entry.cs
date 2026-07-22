using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    private static string separator = "~|~";

    public Entry(string date, string prompt, string repsonse)
    {
        _date = date;
        _prompt = prompt;
        _response = repsonse;
    }

    public void Display()
    {
        Console.WriteLine(_date + ": " + _prompt);
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public string ToFileString()
    {
        string line = _date + separator + _prompt + separator + _response;
        return line;
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split(separator);
        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        Entry entry = new Entry(date, prompt, response);
        return entry;
    }

}