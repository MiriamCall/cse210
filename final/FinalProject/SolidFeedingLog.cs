class SolidFeedingLog : FeedingLog
{
    private string foodType;
    private int foodAmount;
    // private string liked or not;

    public SolidFeedingLog()
    {
        foodType = "";
        foodAmount = 0;
    }

    public void DisplaySolidFeedingLog()
    {
        Console.WriteLine("Solid Feeding Log");
        Console.WriteLine("Food Type: " + foodType);
        Console.WriteLine("Food Amount in cups: " + foodAmount);
    }

    public string GetFoodType()
    {
        return foodType;
    }

    public void SetFoodType(string foodType)
    {
        this.foodType = foodType;
    }

    public int GetFoodAmount()
    {
        return foodAmount;
    }

    public void SetFoodAmount(int foodAmount)
    {
        this.foodAmount = foodAmount;
    }

    public void RecordSolidFeeding()
    {
        Console.WriteLine("Enter food type: ");
        foodType = Console.ReadLine();
        Console.WriteLine("Enter food amount in cups: ");
        string input = Console.ReadLine();
    }
}