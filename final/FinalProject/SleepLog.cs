class SleepLog : Log
{
    private string _sleepType;
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
        Console.WriteLine($"Sleep Duration:  {_duration / 60} hours");
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
            else
            {
                Console.WriteLine("Invalid input. Please enter a sleep type.");
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