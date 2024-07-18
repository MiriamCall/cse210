class TrackingLogs
{
    private List<FeedingLog> _feedingLogs = new List<FeedingLog>();


    public void DisplayFeedingLogs()
    {
        Console.WriteLine ("\nFeeding Logs: ");
        if (_feedingLogs.Count == 0)
        {
            Console.WriteLine("No feeding logs recorded.");
        }
        foreach (FeedingLog log in _feedingLogs)
        {
            int logIndex = _feedingLogs.IndexOf(log) + 1;
            Console.WriteLine(logIndex + ". ");
            log.DisplayFeedingLog();
        }
    }

     public void DisplayLogs()
    {
        DisplayFeedingLogs();
    }

}