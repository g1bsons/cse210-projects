using System;

public class ReflectionActivity : Activity
{
    private string[] _prompts =
    {
        "What drains my energy most, and how can I set boundaries to protect it?",
        "What is one mistake I made recently, and what did it teach me?",
        "What am I holding onto that is hurting me more than helping me?",
        "What does 'success' mean to me right now?"
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base(
        "Reflecting", "This will help you clear out your mind so you can focus on the important")
    {}

    protected override void DoActivity()
    {
        int promptIndex = _random.Next(_prompts.Length);
        Console.WriteLine();
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind please press enter to continue");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_durationSec);

        while (DateTime.Now <endTime)
        {
            int questionIndex = _random.Next(_questions.Length);
            Console.WriteLine();
            Console.WriteLine(_questions[questionIndex]);
            ShowSpinner(5);
        }
    }
}