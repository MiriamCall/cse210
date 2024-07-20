abstract class FeedingLog
{
    protected int _duration;

    public FeedingLog()
    {
        _duration = 0;
    }
    public void DisplayFeedingLog()
    {
        Console.WriteLine("Feeding Log");
        Console.WriteLine($"Duration:  {_duration}");

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
            "Nursing" => new NursingLog().Parse(logData),
            "Bottle" => new BottleFeedingLog().Parse(logData),
            "Solid" => new SolidFeedingLog().Parse(logData),
            _ => throw new Exception("Unknown log type")
        };
    }

    public abstract override string ToString();
    public abstract FeedingLog Parse(string logData);
}