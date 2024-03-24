using System;

public class BreathingActivity : Activities{

    // no need of variables


    // no need of variables

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. 
// Clear your mind and focus on your breathing."
// After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
// After each message, the program should pause for several seconds and show a countdown.
// It should continue until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.
    public  BreathingActivity(string name, string description, int duration) : base (name, description, duration){
        
        DisplayMessage("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Thread.Sleep(3000);
        int limit = 0;
        int pauses=0;
        do
        {
        Console.Write("Breathe in...");
        CountdownEvent();
        Thread.Sleep(2000);
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.Write("Breathe out...");
        CountdownEvent();
        Thread.Sleep(2000);
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        limit++;
        pauses += 2;
        } while (duration != limit);
        EndingMessage("Breathing-Activity", duration, pauses);
    }

}