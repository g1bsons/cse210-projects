using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Render());
            Console.WriteLine();

            if (scripture.IsAllHidden())
            {
                Console.WriteLine("All words are hidden. Exiting the program.");
                break;
            }

            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }
            Random random = new Random();
            int count = random.Next(1, 4);
            scripture.HideRandomWord(count);
        }
    }


    
}