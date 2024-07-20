class Menu
{
    private int choice = 0;
    private string _filename = "Logs.txt";
    private FileHandler _fileHandler = new FileHandler();
    private TrackingLogs _trackingLogs = new TrackingLogs();

    public void DisplayMenu(){
        Console.Clear();
        while (choice !=6)
        {
            Console.WriteLine("\n1. Record Feeding");
            Console.WriteLine("2. Display Logs");
            Console.WriteLine("3. Save logs");
            Console.WriteLine("4. Load logs");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();
            if(int.TryParse(input, out choice))
            {
                switch(choice)
                {
                    case 1:
                        // Feeding Menu
                        LogSubMenu();
                        break;
                    case 2:
                        // Display logs
                        _trackingLogs.DisplayLogs();
                        break;
                    case 3:
                        // Save logs
                        List<Log> logs = _trackingLogs.GetLogs();
                        FileHandler.SaveLogsToFile(_filename, logs);
                        break;
                    case 4:
                        // Load logs
                        List<Log> loadedLogs = FileHandler.LoadLogsFromFile(_filename);
                        _trackingLogs.SetLogs(loadedLogs);
                        break;
                    case 5:
                        // Quit
                        Console.WriteLine("Thank you for using the Baby Tracker. Have a nice day!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    public void LogSubMenu()
    {
        while (choice != 4)
        {
            Console.WriteLine("\n1. Record Baby Feeding Event");
            Console.WriteLine("2. Record Baby Sleeping Event");
            Console.WriteLine("3. Record Baby Medication Event");
            Console.WriteLine("4. Back");

            string input = Console.ReadLine();
            if(int.TryParse(input, out choice))
            {
                switch(choice)
                {
                    case 1:
                        // Feeding Menu
                        FeedingMenu();
                        break;
                    case 2:
                        // Sleep
                        
                        break;
                    case 3:
                        // Medication Menu
                        MedicationMenu();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }


    public void FeedingMenu()
    {
        Console.WriteLine("1. Nursing");
        Console.WriteLine("2. Bottle Feeding");
        Console.WriteLine("3. Solid Food");
        Console.WriteLine("4. Back");

        string input = Console.ReadLine();
        if(int.TryParse(input, out choice))
        {
            switch(choice)
            {
                case 1:
                    // Record Nursing
                    NursingLog nursingLog = new NursingLog();
                    nursingLog.RecordNursing();
                    _trackingLogs.AddLog(nursingLog);
                    break;
                case 2:
                    // Record Bottle Feeding
                    BottleFeedingLog bottleLog = new BottleFeedingLog();
                    bottleLog.RecordBottleFeeding();
                    _trackingLogs.AddLog(bottleLog);
                    break;
                case 3:
                    // Record Solid Food
                    SolidFeedingLog solidLog = new SolidFeedingLog();
                    solidLog.RecordSolidFeeding();
                    _trackingLogs.AddLog(solidLog);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    public void SleepMenu()
    {
        Console.WriteLine("1. Record Nap Time");
        Console.WriteLine("2. Record Night Sleep");
        Console.WriteLine("3. Back");

        string input = Console.ReadLine();
        if(int.TryParse(input, out choice))
        {
            switch(choice)
            {
                case 1:
                    // RecordNap();
                    break;
                case 2:
                    // RecordNightSleep();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    public void MedicationMenu()
    {
        Console.WriteLine("1. Record Medication");
        Console.WriteLine("2. Record Vaccination");
        Console.WriteLine("3. Back");

        string input = Console.ReadLine();
        if(int.TryParse(input, out choice))
        {
            switch(choice)
            {
                case 1:
                    // RecordMedication();
                    // Record amount();
                    // Record time();
                    break;
                case 2:
                    // RecordVaccination();
                    // Record date();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}