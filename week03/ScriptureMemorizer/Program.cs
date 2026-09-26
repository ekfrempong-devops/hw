using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
    //  Get a random Scripture to present to user
        ScriptureLibrary library = new ScriptureLibrary();

        Scripture scripture = library.GetRandomScripture();

        while (!scripture.IsCompletelyHidden())

    //  Reference reference = new Reference("John", 3, 16);
    //  string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

    //  Reference reference = new Reference("Proverbs", 3, 5, 6);
    //  string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

    //  Scripture scripture = new Scripture(reference, text);
    //  while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();

        if (response.ToLower() == "quit")
        {
            break;
        }

        scripture.HideRandomWords(3);
        
        }

    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());

    }
}