abstract class FeedingLog
{
    protected int _duration;

    protected string _logName;

    protected DateTime _timeStamp = DateTime.Now;

    public FeedingLog()
    {
        _duration = 0;
        _logName = "";
    }
    public virtual void DisplayLog()
    {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"{_logName}:");
        Console.WriteLine($"Timestamp: {_timeStamp}");
        Console.WriteLine($"Duration:  {_duration}");
        Console.WriteLine("\n-----------------------------------------");
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public static FeedingLog CreateLog(string logData)
    {
        string[] parts = logData.Split('|');
        return parts[0] switch
        {
            "Nursing Log" => new NursingLog().Parse(logData),
            "Bottle Feeding Log" => new BottleFeedingLog().Parse(logData),
            "Solid Feeding Log" => new SolidFeedingLog().Parse(logData),
            _ => throw new Exception("Unknown log type")
        };
    }

    public abstract override string ToString();
    public abstract FeedingLog Parse(string logData);
}