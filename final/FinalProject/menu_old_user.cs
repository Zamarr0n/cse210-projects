using System;


public class Menu_Old_User{
private string _menu = $@"

Menu Options 
===============================================
Please select one of the following options: (Please only enter the number).
    
1.- Set a Saving Goal
2.- Learn about financial education 
3.- Saving Data
4.- End Program
    ";
    private string menuFunds = $@"
Please select one of the options:
===============================================
(Remember to only enter the number of the Item)

1.- Vacations Fund
2.- Emergency Fund

        ";
    financialEducation finance = new financialEducation();
    SavingGoals savingGoal = new SavingGoals();
    Saving save = new Saving();
    bool _continue = true;
    private int new_user_vacations;
    private int new_user_emergency;

    public void UserChoice(string userName, int salary, int freelancing_earnings, int rent , int groceries, int user_vacations, int user_emergency){
        while (_continue == true)
        {
            Console.WriteLine(_menu);
        int _userInput = int.Parse(Console.ReadLine());
        if(_userInput == 1){
            Console.Write("Saving Goal");
            Spinning();
            Console.WriteLine("");
            Console.WriteLine(menuFunds);
            Console.Write("Which goal would you like to set:");
            int inputUser = int.Parse(Console.ReadLine());
            if (inputUser == 1){
                new_user_vacations = FundAdding(user_vacations);
            } else if(inputUser == 2){
                new_user_emergency = FundAdding(user_emergency);
            }
        } else if(_userInput == 2){
            Console.WriteLine("Learn financial education");
            Spinning();
            Console.WriteLine(finance.financialTips());
        } else if(_userInput == 3){
            Console.Write("Saving data....");
            Spinning();
            Console.WriteLine("");
            Console.WriteLine("Do you still want to continue? Y/N: ");
            string answer = Console.ReadLine();
            if(answer =="Y"){
                // need all the parmeters to work
                Console.WriteLine("Please provide the name of your file: ");
                string textFile = Console.ReadLine();
                save.savingData(textFile,salary, freelancing_earnings,rent,groceries, new_user_emergency, new_user_vacations);
            }else if (answer == "N"){
                break;
            }else{
                Console.WriteLine("Please enter a valid option.");
            }
        } else if (_userInput == 4){
            //program ending
            Console.WriteLine("Thank you for your time :) ");
            Console.Write("...");
            // Ending the loop so the program end.
            _continue = false;
        }
        }
        

    }
    public int FundAdding(int previousQuantity){
        Console.WriteLine("How much would you like to invest?: ");
        int newQuantity = int.Parse(Console.ReadLine());
        int totalQuantity = previousQuantity + newQuantity;
        return totalQuantity;
    }
    // Animation class 
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
    //Animation Section End
}


