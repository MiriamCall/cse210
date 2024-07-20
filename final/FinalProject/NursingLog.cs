class NursingLog : FeedingLog
{
    private int leftBreastDuration;
    private int rightBreastDuration;

    public NursingLog()
    {
        leftBreastDuration = 0;
        rightBreastDuration = 0;
    }

    public void DisplayNursingLog()
    {
        Console.WriteLine("Nursing Log");
        Console.WriteLine($"Duration:  {_duration}");
        Console.WriteLine("Left Breast Duration: " + leftBreastDuration);
        Console.WriteLine("Right Breast Duration: " + rightBreastDuration);
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
        return $"Nursing Log|{_duration}|{leftBreastDuration}|{rightBreastDuration}";
    }

    public override FeedingLog Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new NursingLog
        {
            _duration = int.Parse(parts[0]),
            leftBreastDuration = int.Parse(parts[1]),
            rightBreastDuration = int.Parse(parts[2])
        };
    }
}