class Breathing : Activity
{

    private string _in = "Breathe in...";
    private string _out = "Breathe out...";


    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

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