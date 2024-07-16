class Menu
{
    private int choice = 0;

    public void DisplayMenu(){
        Console.Clear();
        while (choice !=4)
        {
            Console.WriteLine("1. Record Feeding");
            Console.WriteLine("2. Record Sleep");
            Console.WriteLine("3. Record Medication");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();
            if(int.TryParse(input, out choice))
            {
                switch(choice)
                {
                    case 1:
                        
                        // RecordFeeding();
                        break;
                    case 2:
                        // RecordSleep();
                        break;
                    case 3:
                        // RecordMedication();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}