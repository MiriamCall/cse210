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



    public Reflection()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void StartReflection()
    {
        Console.Clear();
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine(_description);
        GetDuration(); // Assuming this method sets _duration based on user input
        Console.WriteLine(_startMessage);
        waitTimerAnimation();

        int promptIndex = 0;
        int questionIndex = 0;
        while (_duration > 0)
        {
            Console.Clear();
            Console.WriteLine(_prompts[promptIndex]);
            Console.WriteLine(_questions[questionIndex]);
            Thread.Sleep(5000);
            _duration -= 10;
            promptIndex++;
            questionIndex++;
            if (promptIndex == _prompts.Count)
            {
                promptIndex = 0;
            }
            if (questionIndex == _questions.Count)
            {
                questionIndex = 0;
            }
        }
    }
}