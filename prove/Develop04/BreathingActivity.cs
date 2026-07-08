using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing", "This will help you relax by focusing on your breathing and letting go of everything else.")
    {}

    protected override void DoActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_durationSec);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);

            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
        }
    }
}