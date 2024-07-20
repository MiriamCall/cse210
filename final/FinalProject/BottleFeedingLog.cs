class BottleFeedingLog : Log
{
    private int _bottleAmount;
    private string _milkType;

    public BottleFeedingLog()
    {
        _bottleAmount = 0;
        _milkType = "";
        _logName = "Bottle Feeding Log";
    }

    public override void DisplayLog()
    {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"{_logName}:");
        Console.WriteLine($"Timestamp: {_timeStamp}");
        Console.WriteLine($"Duration: {_duration} minutes");
        Console.WriteLine($"Amount of {_milkType}: {_bottleAmount} oz");
        Console.WriteLine("-----------------------------------------\n");
    }

    public int GetBottleAmount()
    {
        return _bottleAmount;
    }

    public void SetBottleAmount(int bottleAmount)
    {
        _bottleAmount = bottleAmount;
    }

    public string GetMilkType()
    {
        return _milkType;
    }

    public void SetMilkType(string milkType)
    {
        _milkType = milkType;
    }

    public void RecordBottleFeeding()
    {
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine("Enter bottle amount in oz: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int bottleAmount))
            {
                SetBottleAmount(bottleAmount);

                Console.WriteLine("Enter milk type: ");
                string milkType = Console.ReadLine();
                if (!string.IsNullOrEmpty(milkType))
                {
                    SetMilkType(milkType);

                    Console.WriteLine("Enter feeding duration in minutes: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int duration))
                    {
                        SetDuration(duration);
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for feeding duration. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for milk type. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for bottle amount. Please try again.");
            }
        }
    }


    public override string ToString()
    {
        return $"{_logName}|{_timeStamp}|{_duration}|{_bottleAmount}|{_milkType}";
    }
    public override Log Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new BottleFeedingLog
        {
            _logName = parts[0],
            _timeStamp = DateTime.Parse(parts[1]),
            _duration = int.Parse(parts[2]),
            _bottleAmount = int.Parse(parts[3]),
            _milkType = parts[4]
        };
    }
}