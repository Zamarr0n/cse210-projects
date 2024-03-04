using System;
using System.Formats.Asn1;
using System.IO;

class Program
{
    static Random rnd = new Random();
    static void Main(string[] args)
    {
//  Contain classes for the major components in the program.
// Contain at least two classes in addition to the Program class.
// Demonstrate the principle of abstraction by using member variables and methods appropriately
    
    List <string> list_activities = new List<string>();
    List <string> list_questions = new List<string>();
    List <string> list_data = new List<string>();
    string Answer_question;
    string file_name;
    int Answer_number;
    string option1 = "1. Write";
    string option2 = "2. Display";
    string option3 = "3. Load";
    string option4 = "4. Save";
    string option5 = "5. Quit";
    string question1 = "If I had one thing I could do better what would it be?: ";
    string question2 = "What was the best part of your day?: ";
    string question3 = "Is it there something that makes you worry about?: ";
    string question4 = "Are you taking the steps towards your dream?: ";
    string question5 = "How did I see the hand of the Lord in my life today?";
    list_activities.Add(option1);
    list_activities.Add(option2);
    list_activities.Add(option3);
    list_activities.Add(option4);
    list_activities.Add(option5);
    // -------------------------------
    list_questions.Add(question1);
    list_questions.Add(question2);
    list_questions.Add(question3);
    list_questions.Add(question4);
    list_questions.Add(question5);

    do
    {
    Console.WriteLine("Please Select one of the options Below: ");
    foreach (var item in list_activities)
    {
        Console.WriteLine(item);
    }
    Console.Write("What would you like to do?: ");
    string Answer = Console.ReadLine();
    Answer_number = int.Parse(Answer);

    if( Answer_number == 1){
        int r = rnd.Next(list_questions.Count);
        string randomElement = list_questions[r];
        Console.WriteLine($"Question: {randomElement}");
        Answer_question = Console.ReadLine();
        list_data.Add(randomElement);
        list_data.Add(Answer_question);
    }
    else if(Answer_number == 2){
        Console.WriteLine("--------------------------------");
        foreach (var item in list_data)
        {
            Console.WriteLine($"{item}");
        }
        Console.WriteLine("--------------------------------");
    }
    else if(Answer_number == 3){
        Console.WriteLine("Please Enter the file name (Don´t forget to include the .txt extension and write a proper file name): ");
        file_name = Console.ReadLine();
        Console.WriteLine("Reading file ... ");
        ReadingFile(file_name);
    }
    else if(Answer_number == 4){
        if (list_data.Count == 0){
            Console.WriteLine("You cant save an empty file");
        }
        Console.Write("Enter the name of the file (Don´t forget to include the .txt extension and write a proper file name): ");
        file_name = Console.ReadLine();
        Saving_Data(list_data, file_name);
    }
    else if(Answer_number == 5){
        Console.WriteLine("The program has ended");
    }
    else{
        Console.WriteLine("Please enter a valid option");
    }    
    } while (Answer_number != 5);

        // Console.WriteLine("Hello Develop02 World!");
    }
    public static void Saving_Data(List<string> data , string fileName){
        Console.WriteLine("Saving to File ... ");
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        using (StreamWriter outputFile = new StreamWriter(fileName))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("Data: ");
    foreach (var item in data)
    {
        outputFile.WriteLine($"Date: {dateText}  -  Prompt: {item}");
    }
    // You can use the $ and include variables just like with Console.WriteLine
}
    }
    public static void ReadingFile(string FileName){
    string[] lines = System.IO.File.ReadAllLines(FileName);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
        
    }
}