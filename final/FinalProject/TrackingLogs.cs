class TrackingLogs
{
    private List<Log> _logs = new List<Log>();


    public void DisplayLogs()
    {
        Console.WriteLine ("\nFeeding Logs: ");
        if (_logs.Count == 0)
        {
            Console.WriteLine("No feeding logs recorded.");
        }
        foreach (Log log in _logs)
        {
            int logIndex = _logs.IndexOf(log) + 1;
            Console.WriteLine(logIndex + ". ");
            log.DisplayLog();
        }
    }

    public void AddLog(Log log)
    {
        _logs.Add(log);
    }

    public List<Log> GetLogs()
    {
        return _logs;
    }

    public void SetLogs(List<Log> logs)
    {
        _logs = logs;
    }
}