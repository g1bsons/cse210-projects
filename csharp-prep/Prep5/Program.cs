using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = get_username();

    }
      
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string get_username()
    {
        Console.WriteLine("Whats your name?");
        string name = Console.ReadLine();
        return name;
    }

}
