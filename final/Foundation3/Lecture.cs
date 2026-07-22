using System; 

public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base("Lecture", title, description, date, time, address)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public string GetSpeakerName()
    {
        return speakerName;
    }
    public int GetCapacity()
    {
        return capacity;
    }

    public string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details = details + "Speaker: " + speakerName + "\n";
        details = details + "Capacity: " + capacity + "\n";
        return details;
    }
}