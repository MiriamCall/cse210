class FileHandler
{
    private List<FeedingLog> _feedingLogs = new List<FeedingLog>();

    public void AddFeedingLog(FeedingLog log)
    {
        _feedingLogs.Add(log);
    }

    public FeedingLog GetFeedingLog(FeedingLog log)
    {
        return log;
    }

    public void DisplayLogs()
    {
        foreach (FeedingLog log in _feedingLogs)
        {
            log.DisplayFeedingLog();
        }
    }

    public void SaveLogsToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (FeedingLog log in _feedingLogs)
            {
                writer.WriteLine(log.ToString());
            }
        }
    }
    {
        
    }
}