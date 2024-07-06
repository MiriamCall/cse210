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
        _startMessage = "\nGet ready...";
    }

    public void DisplayWelcomeMessage()
    {
        _welcomeMessage = $"Welcome to the {_name}.\n";
        Console.WriteLine(_welcomeMessage);
    }
    public Activity(string name, string description, int duration, string endMessage)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _endMessage = endMessage;
    }


    public void UpdateDuration()
    {
        bool isValidInput = false;
        while (!isValidInput)
        {
            Console.Write("How long, in seconds, would you like your session? ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out _duration))
            {
                isValidInput = true; // Valid input, set the flag to exit the loop
            }
            else
            {
                // Invalid input, prompt again
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    protected void waitTimerAnimation()
{
    // Define the spinner frames as a string
    string spinner = "|/-\\";
    // Two seconds in milliseconds
    int totalDuration = 2000;
    
    // Assuming we want each frame to display for about 100 milliseconds
    int frameDisplayTime = 100;
    
    // Calculate the total number of iterations based on the total duration and frame display time
    int totalIterations = totalDuration / frameDisplayTime;
    
    for (int i = 0; i < totalIterations; i++)
    {
        // Display the spinner frame by accessing the character in the string by index
        Console.Write(spinner[i % spinner.Length]);
    
        // Sleep to control the speed of the spinner
        System.Threading.Thread.Sleep(frameDisplayTime);
    
        // Overwrite the spinner in the next iteration with backspaces
        Console.Write("\b \b");
    }

    // Ensure the cursor position is moved to the next line after the animation
    Console.WriteLine();
}



    protected void DisplayEndMessage()
    {
        _endMessage = $"You completed the {_name} in {_duration} seconds.\n";
        Console.WriteLine($"Well done! You have completed the {_name}.\n");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine(_endMessage);
        Thread.Sleep(2000); // Pause for another 2 seconds
    }
}