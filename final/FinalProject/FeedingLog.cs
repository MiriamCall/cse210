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

    public DateTime GetStartTime()
    {
        return startTime;
    }

    public void SetStartTime(DateTime startTime)
    {
        startTime = DateTime.Now;
    }

    public DateTime GetEndTime()
    {
        return endTime;
    }

    public void SetEndTime()
    {
        endTime = DateTime.Now;
    }
}