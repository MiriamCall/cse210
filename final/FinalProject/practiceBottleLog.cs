// class BottleFeedingLog : FeedingLog
// {
//     private int bottleAmount;
//     private string milkType;
//     private int feedingDuration;

//     public BottleFeedingLog()
//     {
//         bottleAmount = 0;
//         milkType = "";
//         feedingDuration = 0;
//     }

    

//     public void DisplayBottleFeedingLog()
//     {
//         Console.WriteLine("Bottle Feeding Log");
//         Console.WriteLine("Start Time: " + GetStartTime());
//         Console.WriteLine("End Time: " + GetEndTime());
//         Console.WriteLine("Bottle Amount: " + bottleAmount);
//         Console.WriteLine("Milk Type: " + milkType);
//     }

//     public int GetBottleAmount()
//     {
//         return bottleAmount;
//     }

//     public void SetBottleAmount(int bottleAmount)
//     {
//         this.bottleAmount = bottleAmount;
//     }

//     public int GetFeedingDuration()
//     {
//         return feedingDuration;
//     }
//     public void SetFeedingDuration(int feedingDuration)
//     {
//         this.feedingDuration = feedingDuration;
//     }


// public void RecordBottleFeeding()
// {
//     Console.WriteLine("Enter bottle amount in oz: ");
//     string input = Console.ReadLine();
//     if (int.TryParse(input, out int amount)) // Use a temporary variable for clarity
//     {
//         SetBottleAmount(amount); // Use the setter to ensure consistency

//         Console.WriteLine("Enter milk type: ");
//         milkType = Console.ReadLine(); // Direct assignment is fine here

//         Console.WriteLine("Enter feeding duration in minutes: ");
//         input = Console.ReadLine();
//         if (int.TryParse(input, out int duration))
//         {
//             SetFeedingDuration(duration); // Use the setter to ensure consistency
//             SetEndTime(DateTime.Now); // Assuming SetEndTime takes a DateTime parameter

//             // Optionally, confirm to the user that the log has been recorded
//             Console.WriteLine("Bottle feeding log recorded.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid input for feeding duration. Please try again.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Invalid input for bottle amount. Please try again.");
//     }
// }
// }