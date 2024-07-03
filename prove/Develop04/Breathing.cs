class Breathing : Activity
{

    private string _in = "Breathe in...";
    private string _out = "Breathe out...";


    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // goes in Activity.cs
    // public int GetDuration()
    // {
    //     Console.Write("How long, in seconds, would you like your session? ");
    //     string input = Console.ReadLine();
    //     if (input != "")
    //     {
    //         if (int.TryParse(input, out _duration))
    //         {
    //             return _duration;
    //         }
    //         else
    //         {
    //             Console.WriteLine("Invalid input. Please enter a number.");
    //             return GetDuration();
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid input. Please enter a number.");
    //         return GetDuration();
    //     }
    // }

    // goes in Activity.cs
    // private void waitTimerAnimation()
    // {
    //     // Define the spinner frames as a string
    //     string spinner = "|/-\\";
    //     // Three seconds in milliseconds
    //     int totalDuration = 2000;
    
    //     // Assuming we want each frame to display for about 100 milliseconds
    //     int frameDisplayTime = 100;
    
    //     // Calculate the total number of iterations based on the total duration and frame display time
    //     int totalIterations = totalDuration / frameDisplayTime;
    
    //     // Set the initial cursor position
    //     int left = Console.CursorLeft;
    //     int top = Console.CursorTop;
    
    //     for (int i = 0; i < totalIterations; i++)
    //     {
    //         // Display the spinner frame by accessing the character in the string by index
    //         Console.Write(spinner[i % spinner.Length]);
    
    //         // Reset the cursor position to overwrite the spinner in the next iteration
    //         Console.SetCursorPosition(left, top);
    
    //         // Sleep to control the speed of the spinner
    //         System.Threading.Thread.Sleep(frameDisplayTime);
    //     }
    //     Console.SetCursorPosition(left, top);
    //     Console.WriteLine(" ");
    // }

    public void CountDownTimerInAndOut(int duration, string message)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\r{message}{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Method to start the Breathing Activity
    // This method will display the welcome message, start message, and end message
    // It will display the breathing in and out messages
    // and display a count duration of each in and out breath
    public void StartBreathing()
    {
        Console.Clear();
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine(_description);
        GetDuration(); // Assuming this method sets _duration based on user input
        Console.WriteLine(_startMessage);
        waitTimerAnimation();
    
        // Assuming _duration is in seconds, convert it to milliseconds for Thread.Sleep
        int totalSessionTimeMs = _duration * 1000;
        // Define the duration of each "in" and "out" phase in seconds
        int phaseDurationSec = 6; // Example: 5 seconds for each phase
        // Convert phase duration to milliseconds
        int phaseDurationMs = phaseDurationSec * 1000;
        // Calculate the total number of phases possible within the session
        int totalPhases = totalSessionTimeMs / phaseDurationMs;
        // Assuming an equal number of "in" and "out" phases, the number of cycles is half the total phases
        int numberOfCycles = totalPhases / 2;
        
        for (int i = 0; i < numberOfCycles; i++)
        {
            CountDownTimerInAndOut(phaseDurationSec, _in);
            Console.WriteLine();

            CountDownTimerInAndOut(phaseDurationSec, _out);
            Console.WriteLine("\n");
        }
    
        Console.WriteLine(_endMessage);
    }





}