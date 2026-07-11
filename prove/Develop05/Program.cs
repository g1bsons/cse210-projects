using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Eternal Quest");
            manager.DisplayScore();
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Your Goals");
            Console.WriteLine("3. Record An Event");
            Console.WriteLine("4. Save Your Goals");
            Console.WriteLine("5. Load Your Goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please choose an option from the above menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(manager);
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("The goals are: ");
                manager.DisplayGoals();
            }
            else if (choice == "3")
            {
                RecordEvent(manager);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What file would you like to dave to? ");
                string filename = Console.ReadLine();
                manager.SaveGoals(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("What file would you like to load from? ");
                string filename = Console.ReadLine();
                manager.LoadGoals(filename);
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("PLease select only from the options listed above, please try again");
            }
        }


        // this method gives the goal types to the user and lets them create new ones
        void CreateGoal(GoalManager manager)
        {
            Console.WriteLine();
            Console.WriteLine("The following are the 3 types of goals: ");
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine("2. Eternal Goals");
            Console.WriteLine("3. Checklist Goals");
            Console.WriteLine("Which of the above goals would you like to create? ");
            string type = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("How many points do you have to make this goal worth? ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
            {
                manager.CreateGoal(new SimpleGoal(name, points));
            }
            else if (type == "2")
            {
                manager.CreateGoal(new EternalGoal(name, points));
            }
            else if (type == "3")
            {
                Console.WriteLine("How many times does this goal need to be completed? ");
                int targetAmount = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the bonus point value for completing this goal? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                manager.CreateGoal(new ChecklistGoal(name, points, targetAmount, bonusPoints));
            }
            else
            {
                Console.WriteLine("I'm sorry but that isn't a valid goal type.");
            }
        }


        // this method allows the user to pick a goal and record their progress
        void RecordEvent(GoalManager manager)
        {
            Console.WriteLine();
            Console.WriteLine("THe goals are as follows: ");
            manager.DisplayGoals();
            Console.WriteLine("Which goal did you accomplish? ");
            string input = Console.ReadLine();
            int index;

            if (int.TryParse(input, out index))
            {
                manager.RecordEvent(index -1);
            }
            else
            {
                Console.WriteLine(" Thats not a valid goal number.");
            }
        }
    }
}