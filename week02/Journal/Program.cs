using System.IO;
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";
        while (choice != "5")
        {
             DisplayMenu();
             choice = Console.ReadLine();
             Console.Write(">");
        if (choice == "1")
            {
                Write(journal);
            }

        else if (choice == "2")
            {
                journal.DisplayAll();
            }

        else if (choice == "3")
            {
                Load(journal);
            }

        else if (choice == "4")
            {
                Save(journal);
            }
        }
           
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");       
    }
    static void Write(Journal journal)
    {
    PromptGenerator randomPrompt = new PromptGenerator();
    string prompt = randomPrompt.GetRandomPrompt();
    Console.WriteLine(prompt); 
    string response = Console.ReadLine();
     
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    Entry entry = new Entry(); 
    entry._date = dateText;
    entry._promptText = prompt;
    entry._entryText = response;
    
    journal.AddEntry(entry);        
    }

    static void Save(Journal journal)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void Load(Journal journal)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename); 
    }
        
}