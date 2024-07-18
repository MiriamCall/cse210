class Menu
{
    private int choice = 0;

    public void DisplayMenu(){
        Console.Clear();
        while (choice !=4)
        {
            Console.WriteLine("1. Record Feeding");
            Console.WriteLine("2. Record Sleep");
            Console.WriteLine("3. Record Medication");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();
            if(int.TryParse(input, out choice))
            {
                switch(choice)
                {
                    case 1:

                        FeedingMenu();
                        break;
                    case 2:
                        SleepMenu();
                        break;
                    case 3:
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
                    BreastFeedingLog breastFeedingLog = new BreastFeedingLog();
                    breastFeedingLog.RecordBreastFeeding();
                    
                    // RecordBreastFeeding();
                    break;
                case 2:
                    // RecordBottleFeeding();
                    break;
                case 3:
                    // RecordSolidFood();
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