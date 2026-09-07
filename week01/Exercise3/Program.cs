using System;

class Program
{
    static void Main(string[] args)
   
    {
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        
        while (magicNumber != -1)
        {
        Console.Write ("What is your guess? ");
        string guessedNum = Console.ReadLine();
        int number = int.Parse(guessedNum);
        

        if (number < magicNumber) 
            {
                Console.WriteLine ("Higher");
            }
        else if (number > magicNumber)
            {
                Console.WriteLine ("Lower");
            }
        else
            {
                Console.WriteLine ("You guessed it!");
                break;
            }
       

        }



    }


        
}