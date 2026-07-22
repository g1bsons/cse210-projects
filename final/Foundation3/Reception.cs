using System;

public class Reception : Event
{
    private string email;

    public Reception(string title, string description, string date, string time, Address address, string email)
        :base("Reception", title, description, date, time, address)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details = details + "Email: " + email + "\n";
        return details;
    }
}