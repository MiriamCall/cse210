class Menu
{
    private int choice = 0;

    private Goal _goal = new Goal();
    public void DisplayMenu(
        {
            while choice !=6
            {
                Console.WriteLine("1. Create New Goal")
                Console.WriteLine("2. List Goals")
                Console.WriteLine("3. Save Goals")
                Console.WriteLine("4. Load Goals")
                Console.WriteLine("5. Record Event")
                Console.WriteLine("6. Quit");

                string input = Console.ReadLine();
                if(int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            while choice !=3
                            {
                                Console.WriteLine("1. Simple Goal")
                                Console.WriteLine("2. Eternal Goal")
                                Console.WriteLine("3. Checklist Goal")

                                string input = Console.ReadLine();
                                if(int.TryParse(input, out choice))
                                {
                                    switch (choice)
                                    {
                                        case 1:
                                            // Create Simple Goal
                                            break;
                                        case 2:
                                            // Create Eternal Goal
                                            break;
                                        case 3:
                                            // Create Checklist Goal
                                            break;
                                    }
                                }
                            }
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            
                            break;
                        case 4:
                           
                            break;
                        case 5:
                            
                            break;
                        case 6:
                            // Quit
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    )
}