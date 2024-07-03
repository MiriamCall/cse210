class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected string _welcomeMessage;
    protected string _endMessage;
    protected string _startMessage;
    public Activity()
    {
        _name = "Activity";
        _description = "This is a generic activity.";
        _welcomeMessage = $"Welcome to the {_name}.\n";
        _endMessage = $"Well done! You have completed the {_name} in {_duration} minutes.";
        _startMessage = "\nGet ready...";
    }
    public Activity(string name, string description, int duration, string endMessage)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _endMessage = endMessage;
    }
}