class SleepLog : Log
{
    private string _sleepType;

    private int _hours;
    public SleepLog()
    {
        _logName = "Sleep Log";
        _sleepType = "";
    }

    public override void DisplayLog()
    {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"{_logName}:");
        Console.WriteLine($"Timestamp: {_timeStamp}");
        Console.WriteLine($"Sleep Type: {_sleepType}");
        Console.WriteLine($"Sleep Duration:  {_hours} hours");
        Console.WriteLine($"Sleep Duration:  {_duration} minutes");
        Console.WriteLine("-----------------------------------------\n");
    }

    public string GetSleepType()
    {
        return _sleepType;
    }

    public void SetSleepType(string sleepType)
    {
        _sleepType = sleepType;
    }

    public void RecordSleep()
    {
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine("Enter sleep type: ");
            string sleepType = Console.ReadLine();
            if (!string.IsNullOrEmpty(sleepType))
            {
                SetSleepType(sleepType);
                Console.Write("Do you want to enter sleep duration in minutes? (y/n) ");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    Console.WriteLine("Enter sleep duration in minutes: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int duration))
                    {
                        SetDuration(duration);
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                else if (response == "n")
                {
                    Console.WriteLine("Enter sleep duration in hours: ");
                    string hoursInput = Console.ReadLine();
                    if (int.TryParse(hoursInput, out int hours))
                    {
                        SetDuration(hours * 60);
                        _hours = hours;
                        valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter y or n.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a sleep type.");
            }
            }
        }
    }


    public override string ToString()
    {
        return $"{_logName}|{_timeStamp}|{_duration}";
    }

    public override Log Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new SleepLog
        {
            _logName = parts[0],
            _timeStamp = DateTime.Parse(parts[1]),
            _duration = int.Parse(parts[2]),
            _sleepType = parts[3]
        };
    }
}