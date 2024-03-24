using System;

public class Activities{
    private string _name;
    private string _description;
    private int _duration;

// Have a menu system to allow the user to choose an activity.
// Each activity should start with a common starting message that provides the name of the activity,
//  a description, and asks for and sets the duration of the activity in seconds. 
// Then, it should tell the user to prepare to begin and pause for several seconds.
// Each activity should end with a common ending message that tells the user they have done a good job,

// and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
// Whenever the application pauses it should show some kind of animation to the user, 
// such as a spinner, a countdown timer, or periods being displayed to the screen.
// The interface for the program should remain generally true to the one shown in the video demo.
    
    //Constructor class.
    public Activities(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void  DisplayMessage(string name, string description){
        // return "Hello, welcome to the " + name + description + "with a duration of " + duration;
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine(" ");
        Console.WriteLine($"{description}");
        Console.WriteLine(" ");
        Console.WriteLine("How long, in seconds, would you like for your session: ");
        string duration = Console.ReadLine();
    }
    // animation section 
    public void CountdownEvent(){
        for (int i = 5; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinning(){
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    foreach (string s in animationStrings)
    {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
    }
    }
    // animation section 
    
    public void EndingMessage(string activity, int time, int pauses){
        Console.Write("Perfect you have done a nice job...");
        Spinning();
        Thread.Sleep(5000);
        Console.WriteLine($"You have completed the {activity} activity, in {time} seconds, with {pauses} pauses");
        
    }

    // public string SetDescription(string _description){

        

    // }


}