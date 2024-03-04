// using System;


// public class SavingData{
//     public string FileName;
//     public static void Saving_Data(List<string> data , string fileName){
//         Console.WriteLine("Saving to File ... ");
//         DateTime theCurrentTime = DateTime.Now;
//         string dateText = theCurrentTime.ToShortDateString();
//         using (StreamWriter outputFile = new StreamWriter(fileName))
// {
//     // You can add text to the file with the WriteLine method
//     outputFile.WriteLine("Data: ");
//     foreach (var item in data)
//     {
//         outputFile.WriteLine($"Date: {dateText}  -  Prompt: {item}");
//     }
//     // You can use the $ and include variables just like with Console.WriteLine
// }
//     }
// }



