using System; 

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base("Lecture", title, description, date, time, address)
    {
        this._speakerName = speakerName;
        this._capacity = capacity;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }
    public int GetCapacity()
    {
        return _capacity;
    }

    public string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details = details + "Speaker: " + _speakerName + "\n";
        details = details + "Capacity: " + _capacity + "\n";
        return details;
    }
}