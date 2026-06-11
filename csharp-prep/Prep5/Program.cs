using System;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = get_username();
        int number = fav_number();
        int year;
        get_birth_year(out year);
        int square = squared_number(number);
        display_text(name, square, year);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    static string get_username()
    {
        Console.Write("Whats your name? ");
        string name = Console.ReadLine();
        return name;
    }


    static int fav_number()
    {
        Console.Write("Whats your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }


    static void get_birth_year(out int year)
    {
        Console.Write("Whats year were you born in? ");
        year = int.Parse(Console.ReadLine());
    }


    static int squared_number(int number)
    {
        int square = number * number;
        return square;
    }


    static void display_text(string name, int squared_number, int get_birth_year)
    {
        int this_year = DateTime.Now.Year;

        Console.WriteLine($"{name}, the square of your favorite number is {squared_number}.");
        Console.WriteLine($"Congrats {name}, this year you will turn {this_year - get_birth_year}.");
    }

}
