using System;

class Program
{
    static void Main(string[] args)
    {
// Isaíah 53 4-5:
// 4 Surely he hath borne our griefs, and carried our sorrows: 
// yet we did esteem him stricken, smitten of God, and afflicted.

// 5 But he was wounded for our transgressions, 
// he was bruised for our iniquities: the chastisement of our peace was upon him; 
// and with his stripes, we are healed.

// Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
// Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
// Clear the console screen and display the complete scripture, including the reference and the text.
// Prompt the user to press the enter key or type quit.
// If the user types quit, the program should end.
// If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, 
// and display the scripture again.
// The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
// When all words in the scripture are hidden, the program should end.
// When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden.
// (As a stretch challenge, try to randomly select from only those words that are not already hidden.)
        bool finish;
        do
        {
        finish = false;
        string scripture = " Isaíah 53 4-5: Surely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted. But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes, we are healed.";
        Console.WriteLine(scripture);
        Console.Write("press enter or type quit to end the program: ");
        string input_user = Console.ReadLine();
        // var input2 = Console.ReadLine();
        if (input_user == "quite"){
            finish = true;
            break;
        } 
        else{
            RemoveWords remove = new RemoveWords(scripture);
        }
        } while (finish == true);
    }
}