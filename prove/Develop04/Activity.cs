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


    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        string input = Console.ReadLine();
        if (input != "")
        {
            if (int.TryParse(input, out _duration))
            {
                return _duration;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return GetDuration();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return GetDuration();
        }
    }

    protected void waitTimerAnimation()
    {
        // Define the spinner frames as a string
        string spinner = "|/-\\";
        // Three seconds in milliseconds
        int totalDuration = 2000;
    
        // Assuming we want each frame to display for about 100 milliseconds
        int frameDisplayTime = 100;
    
        // Calculate the total number of iterations based on the total duration and frame display time
        int totalIterations = totalDuration / frameDisplayTime;
    
        // Set the initial cursor position
        int left = Console.CursorLeft;
        int top = Console.CursorTop;
    
        for (int i = 0; i < totalIterations; i++)
        {
            // Display the spinner frame by accessing the character in the string by index
            Console.Write(spinner[i % spinner.Length]);
    
            // Reset the cursor position to overwrite the spinner in the next iteration
            Console.SetCursorPosition(left, top);
    
            // Sleep to control the speed of the spinner
            System.Threading.Thread.Sleep(frameDisplayTime);
        }
        Console.SetCursorPosition(left, top);
        Console.WriteLine(" ");
    }
}