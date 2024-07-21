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
            Console.WriteLine("\n1. Record Baby Log");
            Console.WriteLine("2. Display Baby Logs");
            Console.WriteLine("3. Save Baby logs");
            Console.WriteLine("4. Load Baby logs");
            Console.WriteLine("5. Clear All logs");
            Console.WriteLine("6. Exit");

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
                        // Clear all logs
                        _trackingLogs.ClearLogs();
                        break;
                    case 6:
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
        choice = 0;
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
                        choice = 4;
                        break;
                    case 2:
                        // Sleep
                        SleepLog sleepLog = new SleepLog();
                        sleepLog.RecordSleep();
                        _trackingLogs.AddLog(sleepLog);
                        choice = 4;
                        break;
                    case 3:
                        // Medication Menu
                        MedicationLog medicationLog = new MedicationLog();
                        medicationLog.RecordMedication();
                        _trackingLogs.AddLog(medicationLog);
                        choice = 4;
                        break;
                    case 4:
                        choice = 4;
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
}