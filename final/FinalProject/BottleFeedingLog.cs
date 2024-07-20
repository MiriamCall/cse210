class BottleFeedingLog : FeedingLog
{
    private int _bottleAmount;
    private string _milkType;

    public BottleFeedingLog()
    {
        _bottleAmount = 0;
        _milkType = "";
    }

    

    public void DisplayBottleFeedingLog()
    {
        Console.WriteLine($"Bottle Feeding Log:\n Duration: {_duration}\n Amount of {_milkType}: {_bottleAmount}");
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
        return $"Bottle Feeding Log|{_duration}|{_bottleAmount}|{_milkType}";
    }
    public override FeedingLog Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new BottleFeedingLog
        {
            _duration = int.Parse(parts[0]),
            _bottleAmount = int.Parse(parts[1]),
            _milkType = parts[2]
        };
    }
}