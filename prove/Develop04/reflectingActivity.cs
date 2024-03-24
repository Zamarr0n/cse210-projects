using System;

public class ReflectingActivity : Activities{
    private List <string> _prompt =  new List<string>();
    private List <string> _question = new List<string>();

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
// After the starting message, select a random prompt to show the user such as:

// Think of a time when you stood up for someone else.
// Think of a time when you did something really difficult.
// Think of a time when you helped someone in need.
// Think of a time when you did something truly selfless.

// After displaying the prompt, the program should ask the user to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:

// Why was this experience meaningful to you?
// Have you ever done anything like this before?
// How did you get started?
// How did you feel when it was complete?
// What made this time different than other times when you were not as successful?
// What is your favorite thing about this experience?
// What could you learn from this experience that applies to other situations?
// What did you learn about yourself through this experience?
// How can you keep this experience in mind in the future?

// After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
// It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration){
        DisplayMessage("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(2000);
        int limit = 0;
        int pauses = 1;
        do
        {
            Console.WriteLine(GetRandomQuestion());
            Spinning();
            Thread.Sleep(3000);
            pauses++;
            limit++;
        } while (duration != limit);
        EndingMessage("Reflecting Activity", duration, pauses);
    }
    // public Run(int seconds){
//         DateTime startTime = DateTime.Now;
// DateTime futureTime = startTime.AddSeconds(5);

// Thread.Sleep(3000);

// DateTime currentTime = DateTime.Now;
// if (currentTime < futureTime)
// {
//     Console.WriteLine("We have not arrived at our future time yet...")
// }
    // }
    public string GetRandomPrompt(){
        List<string> new_prompts = _prompt;
        _prompt.Add("Think of a time when you stood up for someone else.");
        new_prompts.Add("Think of a time when you did something really difficult.");
        new_prompts.Add("Think of a time when you helped someone in need.");
        new_prompts.Add("Think of a time when you did something truly selfless.");
        Random rnd = new Random();
        int r = rnd.Next(new_prompts.Count);
        return new_prompts[r];
    }

    public string GetRandomQuestion(){
        List <string> question = _question;
        question.Add("Why was this experience meaningful to you?");
        question.Add("Have you ever done anything like this before?");
        question.Add("How did you get started?");
        question.Add("How did you feel when it was complete?");
        question.Add("What made this time different than other times when you were not as successful?");
        question.Add("What is your favorite thing about this experience?");
        question.Add("What could you learn from this experience that applies to other situations?");
        question.Add("What did you learn about yourself through this experience?");
        question.Add("How can you keep this experience in mind in the future?");
        Random rnd = new Random();
        int r = rnd.Next(question.Count);
        return question[r];
    }
}