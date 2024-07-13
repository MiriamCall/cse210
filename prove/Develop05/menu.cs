class Menu
{
    private GoalTracker _goalTracker = new GoalTracker();
    private int choice = 0;
    public void DisplayMenu()
    {
        while (choice !=6)
        {
            _goalTracker.DisplayPoints();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string input = Console.ReadLine();
            if(int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Create New Goal
                        DisplayCreateGoalMenu();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        bool isValidGoalNumber = false;
                        int goalNum = 0;
                        
                        while (!isValidGoalNumber)
                        {
                            Console.Write("Which Goal did you accomplish? ");
                            isValidGoalNumber = int.TryParse(Console.ReadLine(), out goalNum);
                            if (!isValidGoalNumber)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        }

                        break;
                    case 6:
                        // Quit
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
    public void DisplayCreateGoalMenu()
{
    int createGoalChoice = 0;
    while (createGoalChoice !=4)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Back");
        Console.Write("What type of goal would you like to create? ");

        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out createGoalChoice))
        {
            switch (createGoalChoice)
            {
                case 1:
                    // Create Simple Goal
                    Console.Write("Enter the name of the goal: ");
                    string simpleGoalName = Console.ReadLine();
                    Console.Write("Enter the description of the goal: ");
                    string simpleGoalDescription = Console.ReadLine();
                    Console.Write("Enter the number of points for the goal: ");
                    string simpleGoalPoints = Console.ReadLine();
                    Console.Write("Is the goal completed? (true/false): ");
                    string simpleGoalCompleted = Console.ReadLine();

                    // _goal = new SimpleGoal(name, description, points, completed);
                    break;
                case 2:
                    // Create Eternal Goal
                    Console.Write("Enter the name of the goal: ");
                    string EternalGoalName = Console.ReadLine();
                    Console.Write("Enter the description of the goal: ");
                    string EternalGoalDescription = Console.ReadLine();
                    Console.Write("Enter the number of points for the goal: ");
                    string EternalGoalPoints = Console.ReadLine();

                    // _goal = new EternalGoal(name, description, points, completed);
                    break;

                case 3:
                    // Create Checklist Goal
                    Console.Write("Enter the name of the goal: ");
                    string ChecklistGoalName = Console.ReadLine();
                    Console.Write("Enter the description of the goal: ");
                    string ChecklistGoalDescription = Console.ReadLine();
                    Console.Write("Enter the number of points for the goal: ");
                    string ChecklistGoalPoints = Console.ReadLine();
                    Console.Write("Is the goal completed? (true/false): ");
                    string ChecklistGoalCompleted = Console.ReadLine();

                    // _goal = new ChecklistGoal(name, description, points, completed);
                    break;
            }
        }
    }
}
}