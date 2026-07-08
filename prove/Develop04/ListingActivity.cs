using System;

public class ListingActivity : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are things you're grateful for?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing", "This will help you reflect and focus on the good in your life right now")
    {}

    protected override void DoActivity()
    {
        int promptIndex = _random.Next(_prompts.Length);
        Console.WriteLine();
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine();
        Console.WriteLine("You will have 5 seconds to think about your answer.");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Now start listing your items. Please press enter after typing each item in your list");

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_durationSec);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items, that's amazing!");
    }
}