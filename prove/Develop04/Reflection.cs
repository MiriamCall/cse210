class Reflection : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private static int _lastPromptIndex = -1; // Static to keep track of the last used prompt across instances

    public Reflection()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void StartReflection()
    {
        Console.Clear();
        DisplayWelcomeMessage();
        Console.WriteLine(_description);
        UpdateDuration();
        Console.WriteLine(_startMessage);
        waitTimerAnimation();

        _lastPromptIndex = (_lastPromptIndex + 1) % _prompts.Count; // Rotate to the next prompt
        string prompt = _prompts[_lastPromptIndex];

        Console.Clear();
        Console.WriteLine($"{prompt}\n");

        int timeSpent = 0;
        for (int i = 0; i < _questions.Count && timeSpent < _duration; i++)
        {
            Console.WriteLine($"    -> {_questions[i]}");
            Thread.Sleep(5000);
            timeSpent += 5;
        }

        DisplayEndMessage();
    }
}


