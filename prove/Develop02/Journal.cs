using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;
    private List<string> _prompts;
    private Random _random;

    public Journal()
    {
        _entries = new List<Entry>();
        _random = new Random();
        _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public void WriteNewEntry()
    {
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename for the journal file?");
        string filename = Console.ReadLine();
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            string line = entry.ToFileString();
            lines.Add(line);
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved to " + filename);
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename to load from?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();
        foreach (string line in lines)
        {
            Entry entry = Entry.FromFileString(line);
            _entries.Add(entry);
        }
        Console.WriteLine("Journal loaded from " + filename);
    }
}