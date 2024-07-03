using System;

class Program
{
    static void Main(string[] args)
    {
        private int choice = 0;
        public void DisplayMenu()
        {
             while (choice !=4) {
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflection Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");

                string input = Console.ReadLine();
                if(int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1: Console.WriteLine("");
                        // Breathing Activity
                        break;
                        case 2: 
                        // Reflection Activity
                        break;
                        case 3: 
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
}