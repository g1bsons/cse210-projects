using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        // For the stretch, I added a counter to keeop track of how many activities are completed by the user 
        int activitiesCompeted = 0;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Reflection Activity");
            Console.WriteLine(" 3. Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Please select a choice from the menu above");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activitiesCompeted++;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflecting = new ReflectionActivity();
                reflecting.Run();
                activitiesCompeted++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activitiesCompeted++;
            }   
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Please select a valid option from the menu above");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Good job! You completed {activitiesCompeted} activity/activities this session.");
    }
}

