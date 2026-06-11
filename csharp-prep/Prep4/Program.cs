using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int users_number;

        Console.WriteLine("Please enter a series of numbers. When you are finished please type'0' to finish the series.");

        do
        {
            Console.Write("Enter number: ");
            users_number = int.Parse(Console.ReadLine());

            if (users_number != 0)
            {
                numbers.Add(users_number);
            }

        } while (users_number != 0);


        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}
