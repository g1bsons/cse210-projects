using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _durationSec;
    protected Random _random;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _random = new Random();
    }

    public void Run()
    {
        StartActivity();
        DoActivity();
        EndActivity();
    }

    protected void StartActivity()
    {
        Console.WriteLine();
        Console.WriteLine($"Starting the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("How long would you like for your session (in seconds)?");
        _durationSec = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready to start your activity...");
        ShowSpinner(3);
    }

    protected virtual void DoActivity()
    {
        
    }

    protected void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have finished the {_name} Activity for {_durationSec} seconds");
        ShowSpinner(3);
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinnerFrames = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int frameIndex = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerFrames[frameIndex % spinnerFrames.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            frameIndex++;
        }
    }
    
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i >= 10)
            {
                Console.Write("\b\b");
            }
            else
            {
                Console.Write("\b");
            }
        }
    }
}