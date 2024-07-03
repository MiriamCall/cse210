class Breathing : Activity
{
    private string _breathingTechnique;

    public Breathing(string name, string description, int duration, string endMessage, string breathingTechnique) : base(name, description, duration, endMessage)
    {
        _breathingTechnique = breathingTechnique;
    }


    description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
}