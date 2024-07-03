class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private string _endMessage;

    public Activity(string name, string description, int duration, string endMessage)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _endMessage = endMessage;
    }
}