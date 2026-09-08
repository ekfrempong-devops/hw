using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int percentageNumber = int.Parse(gradePercentage);

        string letter = "";
        string sign = "";
        
        
        if (percentageNumber >= 97)
        {
           letter = "A";
           sign = "+";   
        }
        else if (percentageNumber >= 90 && percentageNumber < 93)
        {
            letter = "A";
            sign = "-";
        }
        else if (percentageNumber == 93 || percentageNumber == 94 || percentageNumber == 95 || percentageNumber == 96) 
        {
            letter = "A";
        }


        else if (percentageNumber >= 87 || percentageNumber == 89)
        {
            letter = "B";
            sign = "+";   
        }
        else if (percentageNumber >= 80 && percentageNumber < 83)
        {
            letter = "B";
            sign = "-";
        }
        else if (percentageNumber == 83 || percentageNumber == 84 || percentageNumber == 85 || percentageNumber == 86)
        {
            letter = "B";  
        }


        else if (percentageNumber >= 77 && percentageNumber <=79)
        {
            letter = "C";
            sign = "+";    
        }
        else if (percentageNumber >= 70 && percentageNumber < 73)
        {
            letter = "C";
            sign = "-";   
        }
        else if (percentageNumber == 73 || percentageNumber == 74 || percentageNumber == 75 || percentageNumber == 76)
        {
            letter = "C";     
        }

        
        else if (percentageNumber >= 67 && percentageNumber <=69)
        {
            letter = "D";
            sign = "+";
        }
        else if (percentageNumber >= 60 && percentageNumber < 63)
        {
            letter = "D";
            sign = "-";
        }
        else if (percentageNumber == 63 || percentageNumber == 64 || percentageNumber == 65 || percentageNumber == 66)
        {
            letter = "D";   
        }
        

        else if (percentageNumber < 60)
        {
            letter = "F";
        }

        Console.WriteLine ($"Your grade is {letter}{sign}");

        if (percentageNumber >= 70) 
        {
            Console.WriteLine("Congratulations...You passed!");
        }

        else
        {
            Console.WriteLine("You failed to pass. Better luck next time! ");
        }  

              
        
    }
}