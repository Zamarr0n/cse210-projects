using System;
using System.IO;


public class Saving{



    public void savingData(string userName, int salary, int freelancing_earnings, int rent , int groceries, int emergency_found, int vacation_found){
        string fileName = userName + ".txt";
        int total_savings = emergency_found + vacation_found;

using (StreamWriter outputFile = new StreamWriter(fileName))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine($"{userName}, {salary}, {freelancing_earnings},{rent},{groceries},{emergency_found},{vacation_found} ,{total_savings} ");
    
    // You can use the $ and include variables just like with Console.WriteLine
    // string color = "Blue";
    // outputFile.WriteLine($"My favorite color is {color}");

}
    }
}



