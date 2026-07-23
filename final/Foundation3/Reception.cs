using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email)
        :base("Reception", title, description, date, time, address)
    {
        this._email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details = details + "Email: " + _email + "\n";
        return details;
    }
}