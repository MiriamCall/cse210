class Listing : Activity
{
    private List<string> _listPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void StartListing()
    {
        Console.Clear();
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine(_description);
        GetDuration(); // Assuming this method sets _duration based on user input
        Console.WriteLine(_startMessage);
        waitTimerAnimation();

        string prompt = _listPrompts[new Random().Next(0, _listPrompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin listing. Press Enter after each item. Press Enter twice to finish.");
        Thread.Sleep(5000);

        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (item == "")
            {
                break;
            }
            list.Add(item);
        }
         Console.WriteLine($"You listed {list.Count} items.");
        
        Console.WriteLine(_endMessage);
    }
}