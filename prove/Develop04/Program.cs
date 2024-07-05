using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice !=4)
        {
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            string input = Console.ReadLine();
            if(int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                    // Breathing Activity
                    Breathing _breathing = new Breathing();
                    _breathing.StartBreathing();
                    break;
                    case 2: 
                    Reflection _reflection = new Reflection();
                    _reflection.StartReflection();
                    // Reflection Activity
                    break;
                    case 3: 
                    Listing _listing = new Listing();
                    _listing.StartListing();
                    // Listing Activity
                    break;
                    case 4: 
                    // Exit
                    Environment.Exit(0);
                    break;
                }
            }
        }

    }
}