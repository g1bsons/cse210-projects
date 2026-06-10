using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);

        string letter = "";

        if (percent >= 97)
        {
            letter = "A+";
        }
        else if (percent >=94)
        {
            letter = "A";
        }
        else if (percent >=90)
        {
            letter = "A-";
        }
        else if (percent >= 87)
        {
            letter = "B+";
        }
        else if (percent >=84)
        {
            letter = "B";
        }
        else if (percent >=80)
        {
            letter = "B-";
        }
        else if (percent >= 77)
        {
            letter = "c+";
        }
        else if (percent >=74)
        {
            letter = "c";
        }
        else if (percent >=70)
        {
            letter = "c-";
        }
        else if (percent >= 67)
        {
            letter = "D+";
        }
        else if (percent >=64)
        {
            letter = "D";
        }
        else if (percent >=60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is _{letter}_");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, you didnt pass. Better study more next time");
        }

    }
}