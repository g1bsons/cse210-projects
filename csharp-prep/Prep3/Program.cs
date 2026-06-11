using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        int magic_number = int.Parse(Console.ReadLine());

        int guess = -1;

        Console.WriteLine("What is your guess?");
        guess = int.Parse(Console.ReadLine());

        if (magic_number > guess)
        {
            Console.WriteLine("Higher");    
        }
        else if (magic_number < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Correct!!");
        }
    }
}