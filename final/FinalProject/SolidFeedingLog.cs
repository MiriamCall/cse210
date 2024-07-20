class SolidFeedingLog : Log
{
    private string _foodType;
    private double _foodAmount;
    // private string liked or not;

    public SolidFeedingLog()
    {
        _foodType = "";
        _foodAmount = 0;
        _logName = "Solid Feeding Log";
    }

    public override void DisplayLog()
    {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"{_logName}:");
        Console.WriteLine($"Timestamp: {_timeStamp}");
        Console.WriteLine($"Food Type: {_foodType}");
        Console.WriteLine($"Amount: {_foodAmount} cups");
        Console.WriteLine($"Duration: {_duration} minutes");
        Console.WriteLine("-----------------------------------------\n");
    }

    public string GetFoodType()
    {
        return _foodType;
    }

    public void SetFoodType(string foodType)
    {
        _foodType = foodType;
    }

    public double GetFoodAmount()
    {
        return _foodAmount;
    }

    public void SetFoodAmount(double foodAmount)
    {
        _foodAmount = foodAmount;
    }

    public void RecordSolidFeeding()
    {
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine("Enter food type: ");
            string foodType = Console.ReadLine();
            if (!string.IsNullOrEmpty(foodType))
            {
                SetFoodType(foodType);

                Console.WriteLine("Enter food amount in cups: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double _foodAmount))
                {
                    SetFoodAmount(_foodAmount);

                    Console.WriteLine("Enter feeding duration in minutes: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int duration))
                    {
                        SetDuration(duration);
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for duration. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for food amount. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for food type. Please try again.");
            }
        }
    }

    public override string ToString()
    {
        return $"{_logName}|{_timeStamp}|{_duration}{_foodType}|{_foodAmount}";
    }
    public override Log Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new SolidFeedingLog
        {
            _logName = parts[0],
            _timeStamp = DateTime.Parse(parts[1]),
            _duration = int.Parse(parts[2]),
            _foodType = parts[3],
            _foodAmount = double.Parse(parts[4])
        };
    }
}