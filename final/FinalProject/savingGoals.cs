using System;

public class Goals{

    
//This function will display the warning about the emergency found
// and return the investment 
    public int emergencyFund(){
        Console.WriteLine("WARNING!");
        Console.WriteLine("");
        Console.WriteLine("Remember this is an emergency found, there´s no quantity limit you can save as much as you want,  it will only be used in important situations.");
        Console.Write("How much would you like to save: ");
        int invest = int.Parse(Console.ReadLine());
        return invest;
    }
    public int vacationFund(){
        Console.Write("How much would you like to save for your vacations?: ");
        int vacation_found = int.Parse(Console.ReadLine());
        return vacation_found;
    }

    public int FundAdding(int previousQuantity){
        Console.WriteLine("How much would you like to invest?: ");
        int newQuantity = int.Parse(Console.ReadLine());
        int totalQuantity = previousQuantity + newQuantity;
        return totalQuantity;
    }
    public int FundSubstraction(int previousQuantity, int minusQuantity){
        int totalQuantity = previousQuantity - minusQuantity;
        return totalQuantity;
    }
}






