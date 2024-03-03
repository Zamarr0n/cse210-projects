using System;

class Program
{
    static void Main(string[] args)
    {
    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to C#");
    }
    static string PromptUserName (){
        Console.Write("Whats your Name?: ");
        string UserName = Console.ReadLine();
        Console.WriteLine($"Welcome {UserName}");
        return UserName;
    }
    static int PromptUserNumber (){
        Console.Write("Whats your favorite Number?: ");
        string Number = Console.ReadLine();
        int FavNumber= int.Parse(Number);
        Console.WriteLine($"This is your Favorite Number {FavNumber}");
        return FavNumber;
    }
    static void SquareNumber(int integer){
        int squared = integer * integer;
        Console.WriteLine($"This is the Result:{squared}");
    }
    static void DisplayResult(string UserName, int SquaredNumber){
        Console.WriteLine($"This is your Name: {UserName} and this is your Number squared: {SquaredNumber}");
    }
    DisplayWelcome();
    PromptUserName();
    PromptUserNumber();
    SquareNumber(7);
    DisplayResult("Emilio", 49);
        // Console.WriteLine("Hello Prep5 World!");
    }
}