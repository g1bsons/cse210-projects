using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("2730 W Tibbetts Blvd", "West Wendover", "Nevada", "USA");
        Lecture lecture1 = new Lecture("The Basics of Family Relations", "How to balance the chaos of a family", 
                                              "12/24/2026", "12:00 AM", lectureAddress, "Gregory Smith", 12);

        Address receptionAddress = new Address("490 Pioneer Rd", "Rexburg", "Idaho", "USA");
        Reception reception1 = new Reception("CS 150", "The Ins and Outs of the Digital World", 
                                             "07/23/2026", "9:00 AM", receptionAddress, "rsvp@school.org");
        
        Address outdoorAddress = new Address("9076 E 29th St", "Tulsa", "Oklahoma", "USA");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("The Divine Inspiration", "How to allow yourself to find inner peace in life", 
                                                                  "09/25/2026", "07:00 PM", outdoorAddress, "Mostly cloudy with a high near 75 degrees");


        Console.WriteLine("Lecture");
        Console.WriteLine();
        Console.WriteLine("Details");
        Console.WriteLine(lecture1.GetDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine("Description");
        Console.WriteLine(lecture1.GetDescription());
        Console.WriteLine();

 
        Console.WriteLine("Reception");
        Console.WriteLine();
        Console.WriteLine("Details");
        Console.WriteLine(reception1.GetDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine("Description");
        Console.WriteLine(reception1.GetDescription());
        Console.WriteLine();

 
        Console.WriteLine("Outdoor Gathering");
        Console.WriteLine();
        Console.WriteLine("Details");
        Console.WriteLine(outdoorGathering1.GetDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine("Description");
        Console.WriteLine(outdoorGathering1.GetDescription());
        Console.WriteLine();

    }
}