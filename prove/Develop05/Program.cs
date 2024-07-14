using System;

// To exceed the requirements of the project I added a bad habit tracker. It subtracts points from the total points when a bad habit is recorded. 
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu ();
        menu.DisplayMainMenu();
    }
}