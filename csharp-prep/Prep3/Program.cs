using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number?");
        // int magic_number = int.Parse(Console.ReadLine());
        Random random_number = new Random();
        int magic_number = random_number.Next(1,101);

        int guess = -1;

        while (guess != magic_number)
        {
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
}