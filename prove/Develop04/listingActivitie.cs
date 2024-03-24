using System;

public class ListingActivity : Activities{
    // private int _count;
    private List<string> _prompts = new List<string>();

    private List <string> User_list = new List<string>();

    

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."

// After the starting message, select a random prompt to show the user such as:
// Who are people that you appreciate?
// What are personal strengths of yours?
// Who are people that you have helped this week?
// When have you felt the Holy Ghost this month?
// Who are some of your personal heroes?

// After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
// The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
// The activity them displays back the number of items that were entered.
// The activity should conclude with the standard finishing message for all activities.
    public ListingActivity(string name, string description, int duration) : base ( name, description, duration){
        DisplayMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(1000);
        GetRandomPrompt();
        CountdownEvent();
        Console.Clear();
        int limit = 0;
        int pauses = 0;
        
        do
        {
            GetListFromUser();
            limit++;
            pauses++;
        } while (duration != limit);

        Console.WriteLine("This is your List: ");
        foreach (var item in User_list)
        {
            Console.WriteLine(item);
        }

        EndingMessage("Listing Activity", duration, pauses);
    }

    public void GetRandomPrompt(){
        List <string> New_list = _prompts;
        New_list.Add("Who are people that you appreciate?");
        New_list.Add("What are personal strengths of yours?");
        New_list.Add("Who are people that you have helped this week?");
        New_list.Add("When have you felt the Holy Ghost this month?");
        New_list.Add("Who are some of your personal heroes?");
        Random rnd = new Random();
        int r = rnd.Next(New_list.Count);
        Console.Write(New_list[r]);
    }
    public List<string> GetListFromUser(){
        Console.Write("Please list your thoughts: ");
        string answer = Console.ReadLine();
        User_list.Add(answer);
        return User_list;
    }

}