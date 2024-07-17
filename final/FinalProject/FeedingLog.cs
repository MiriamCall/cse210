class FeedingLog
{
    private DateTime startTime;
    private DateTime endTime;

    public FeedingLog()
    {
        startTime = DateTime.Now;
        endTime = DateTime.Now;
    }
    public void DisplayFeedingLog()
    {
        Console.WriteLine("Feeding Log");
        Console.WriteLine("Start Time: " + startTime);
        Console.WriteLine("End Time: " + endTime);
    }

    // public GetStartTime()

    // public SetStartTime()

    // public GetEndTime()

    // public SetEndTime()
}