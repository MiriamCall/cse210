using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

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
                        case 1:
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        case 4:
                        Environment.Exit(0);
                        break;
                    }
                }
             }
        }
    }
}