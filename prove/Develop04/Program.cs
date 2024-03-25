using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

// DateTime startTime = DateTime.Now;
// DateTime futureTime = startTime.AddSeconds(5);
// Thread.Sleep(3000);
// DateTime currentTime = DateTime.Now;
// if (currentTime < futureTime)
// {
// Console.Write("+");
// Thread.Sleep(500);
// Console.Write("\b \b"); // Erase the + character
// Console.Write("-"); // Replace it with the - character
//     Console.WriteLine("We have not arrived at our future time yet...");
// }
    // Activities actv1 = new Activities("breath", "description", 6);
    // Console.Write(actv1.EndingMessge());
// DateTime startTime = DateTime.Now;
// DateTime futureTime = startTime.AddSeconds(15);
// Thread.Sleep(3000);
// DateTime currentTime = DateTime.Now;
// if (currentTime < futureTime)
// {
//     Console.WriteLine("We have not arrived at our future time yet...");
// }
    Console.WriteLine("Menu Options");
    Console.WriteLine("1.- Start Breathing Activity");
    Console.WriteLine("2.- Start Reflecting Activity");
    Console.WriteLine("3.- Start Listing Activity");
    Console.WriteLine("4.- Quit");
    Console.WriteLine("Select a choice from the menu: ");
    string answer = Console.ReadLine();
    char answer1 = answer.ToCharArray()[0];
    
    if(answer1 == '1'){
        Console.WriteLine("Start Breathing Activity");
        new BreathingActivity("breathing activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life." , 2);
    } else if(answer1 == '2'){
        Console.WriteLine("Start Reflecting Activity");
        new ReflectingActivity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 2);
    } else if(answer1 == '3'){
        Console.WriteLine("Start Listing Activity");
        new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 2);
    } else if(answer1 == '4'){
        Console.WriteLine("The program ended successfully");
    } else{
        Console.WriteLine("Please select one of the options");
    }



    }
    
}