class BottleFeedingLog : FeedingLog
{
    private int bottleAmount;
    private string milkType;
    private int feedingDuration;

    public BottleFeedingLog()
    {
        bottleAmount = 0;
        milkType = "";
        feedingDuration = 0;
    }

    

    public void DisplayBottleFeedingLog()
    {
        Console.WriteLine("Bottle Feeding Log");
        Console.WriteLine("Start Time: " + GetStartTime());
        Console.WriteLine("End Time: " + GetEndTime());
        Console.WriteLine("Bottle Amount: " + bottleAmount);
        Console.WriteLine("Milk Type: " + milkType);
    }

    public int GetBottleAmount()
    {
        return bottleAmount;
    }

    public void SetBottleAmount(int bottleAmount)
    {
        this.bottleAmount = bottleAmount;
    }

    public int GetFeedingDuration()
    {
        return feedingDuration;
    }
    public void SetFeedingDuration(int feedingDuration)
    {
        this.feedingDuration = feedingDuration;
    }

    public void RecordBottleFeeding()
    {
        SetStartTime(DateTime.Now);
        Console.WriteLine("Enter bottle amount in oz: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out bottleAmount))
        {
            Console.WriteLine("Enter milk type: ");
            milkType = Console.ReadLine();
            Console.WriteLine("Enter feeding duration in minutes: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out feedingDuration))
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