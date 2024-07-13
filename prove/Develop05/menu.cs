class Menu
{

    // Private New instance of GoalTracker
    private GoalTracker _goalTracker = new GoalTracker();
    private PersistenceManager _persistenceManager = new PersistenceManager();

    // Private integer variable choice
    private int choice = 0;

    // DisplayMenu: Displays the main menu
    public void DisplayMainMenu()
    {
        Console.Clear();
        while (choice !=6)
        {
            _goalTracker.DisplayPoints();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit\n");

            string input = Console.ReadLine();
            if(int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Create New Goal
                        DisplayCreateNewGoalMenu();
                        break;
                    case 2:
                        // List Goals
                        _goalTracker.DisplayGoals();
                        break;
                    case 3:
                        // Save Goals
                        _persistenceManager.Save("goals.json", _goalTracker);
                        break;
                    case 4:
                        // Load Goals
                        _persistenceManager.Load("goals.json", _goalTracker);
                        break;
                    case 5:
                        // Record Event
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
                            Console.WriteLine();
                        }
                        Goal goal = _goalTracker.GetGoal(goalNum - 1);
                        _goalTracker.RecordEvent(goal);
                        break;
                    case 6:
                        // Quit
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
    public void DisplayCreateNewGoalMenu()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");

        Console.Write("What type of goal would you like to create? ");
        string userInput = Console.ReadLine();

        int createGoalChoice = 0;
        // If the user input is a valid integer parse it to createGoalChoice
        if (int.TryParse(userInput, out createGoalChoice))
        {
            // Switch statement to determine which type of goal to create
            switch (createGoalChoice)
            {
                case 1:
                    // Create Simple Goal
                    SimpleGoal simpleGoal = new SimpleGoal();
                    _goalTracker.AddGoal(simpleGoal);
                    break;

                case 2:
                    // Create Eternal Goal
                    EternalGoal eternalGoal = new EternalGoal();
                    _goalTracker.AddGoal(eternalGoal);
                    break;

                case 3:
                    // Create Checklist Goal
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    _goalTracker.AddGoal(checklistGoal);
                    break;
            }
        }  
    }
}