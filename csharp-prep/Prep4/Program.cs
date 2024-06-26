using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int userNumber = -1;
        while(userNumber !=0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            string response = Console.ReadLine();
            userNumber = int.Parse(response);
           
           if (userNumber !=0)
           {
            numbers.Add(userNumber);
           }
           
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}