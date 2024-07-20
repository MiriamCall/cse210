class NursingLog : FeedingLog
{
    private int leftBreastDuration;
    private int rightBreastDuration;

    public NursingLog()
    {
        leftBreastDuration = 0;
        rightBreastDuration = 0;
        _logName = "Nursing Log";
    }

    public override void DisplayLog()
    {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"{_logName}:");
        Console.WriteLine($"\tLeft Breast Duration: {leftBreastDuration}");
        Console.WriteLine($"\tRight Breast Duration: {rightBreastDuration}");
        Console.WriteLine($"\tTotal Duration:  {_duration}");
        Console.WriteLine("-----------------------------------------\n");
    }

    public int GetLeftBreastDuration()
    {
        return leftBreastDuration;
    }

    public void SetLeftBreastDuration(int leftBreastDuration)
    {
        this.leftBreastDuration = leftBreastDuration;
    }

    public int GetRightBreastDuration()
    {
        return rightBreastDuration;
    }

    public void SetRightBreastDuration(int rightBreastDuration)
    {
        this.rightBreastDuration = rightBreastDuration;
    }

    public void RecordNursing()
    {
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine("Enter left breast duration in minutes: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out leftBreastDuration))
            {
                SetLeftBreastDuration(leftBreastDuration);

                Console.WriteLine("Enter right breast duration in minutes: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out rightBreastDuration))
                {
                    SetRightBreastDuration(rightBreastDuration);
                    SetDuration(leftBreastDuration + rightBreastDuration);
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input for right breast duration. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for left breast duration. Please try again.");
            }
        }
    }

    public override string ToString()
    {
        return $"{_logName}|{_duration}|{leftBreastDuration}|{rightBreastDuration}";
    }

    public override FeedingLog Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new NursingLog
        {
            _duration = int.Parse(parts[1]),
            leftBreastDuration = int.Parse(parts[2]),
            rightBreastDuration = int.Parse(parts[3])
        };
    }
}