class BreastFeedingLog : FeedingLog
{
    private int leftBreastDuration;
    private int rightBreastDuration;

    public BreastFeedingLog()
    {
        leftBreastDuration = 0;
        rightBreastDuration = 0;
    }

    public void DisplayBreastFeedingLog()
    {
        Console.WriteLine("Breast Feeding Log");
        Console.WriteLine("Start Time: " + GetStartTime());
        Console.WriteLine("End Time: " + GetEndTime());
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

    public void RecordBreastFeeding()
    {
        SetStartTime(DateTime.Now);
        Console.WriteLine("Enter left breast duration in minutes: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out leftBreastDuration))
        {
            Console.WriteLine("Enter right breast duration in minutes: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out rightBreastDuration))
            {
                SetEndTime();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
}