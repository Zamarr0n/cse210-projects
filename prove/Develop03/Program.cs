using System;
using System.Collections.Generic;
using System.Linq;
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

        Scripture scripture = new Scripture("Isaíah 53 4-5", "Surely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted. But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes, we are healed.");

        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture!");
                    break;
                }
            }
        }

    }
}

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string reference, string scripture_meaning)
    {
        this.reference = new Reference(reference);
        this.words = scripture_meaning.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference.ToString());
        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideWord()
    {
        List<Word> visibleWords = words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            Random rand = new Random();
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}

// ________________________________________________________

class Reference
{
    public string Text { get; private set; }

    public Reference(string reference)
    {
        Text = reference;
    }

    public override string ToString()
    {
        return Text;
    }
}

// ________________________________________________________
class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
}

