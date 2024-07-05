class Listing : Activity
{
    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    
    private List<string> _listPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void StartListing()
    {
        Console.Clear();
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine(_description);
        GetDuration(); // Assuming this method sets _duration based on user input
        Console.WriteLine(_startMessage);
        waitTimerAnimation();

        int promptIndex = 0;
        while (_duration > 0)
        {
            Console.Clear();
            Console.WriteLine(_listPrompts[promptIndex]);
            Thread.Sleep(5000);
            _duration -= 10;
            promptIndex++;
            if (promptIndex == _listPrompts.Count)
            {
                promptIndex = 0;
            }
        }
        Console.WriteLine(_endMessage);
    }
}