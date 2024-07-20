class SolidFeedingLog : FeedingLog
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
        Console.WriteLine($"Duration: {_duration}");
        Console.WriteLine($"Food Type: {_foodType}");
        Console.WriteLine($"Food Amount in cups: {_foodAmount}");
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
                    valid = true;
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
        return $"{_logName}|{_foodType}|{_foodAmount}";
    }
    public override FeedingLog Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new SolidFeedingLog
        {
            _duration = int.Parse(parts[1]),
            _foodType = parts[2],
            _foodAmount = int.Parse(parts[3])
        };
    }
}