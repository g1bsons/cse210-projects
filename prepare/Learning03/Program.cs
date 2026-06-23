using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Random random = new Random();

        for (int i = 1; i <= 20; i++)
        {
            int top = random.Next(1, 10);
            int bottom = random.Next(1, 10);

            f.SetTop(top);
            f.SetBottom(bottom);

            Console.WriteLine($"Fraction {i}: string: {f.GetFractionString()} Number: {f.GetDecimalValue()}");
}
        }
}