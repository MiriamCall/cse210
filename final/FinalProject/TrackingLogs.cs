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
            log.DisplayLog();
        }
    }

    public void DisplayLogs()
    {
        DisplayFeedingLogs();
    }

    public void AddFeedingLog(FeedingLog log)
    {
        _feedingLogs.Add(log);
    }

    public List<FeedingLog> GetFeedingLogs()
    {
        return _feedingLogs;
    }

    public void SetFeedingLogs(List<FeedingLog> feedingLogs)
    {
        _feedingLogs = feedingLogs;
    }
}