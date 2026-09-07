using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int percentageNumber = int.Parse(gradePercentage);

        if (percentageNumber >= 97)
        {
           string letter = "A";
           string sign = "+";
           Console.WriteLine ($"{letter}{sign}");
           Console.WriteLine ("Congratulations! You passed the course."); 
        }
        else if (percentageNumber >= 90 && percentageNumber < 93)
        {
            string letter = "A";
            string sign = "-";
            Console.WriteLine ($"{letter}{sign}");
            Console.WriteLine ("Congratulations! You passed the course.");
        }
        else if (percentageNumber == 93 || percentageNumber == 94 || percentageNumber == 95 || percentageNumber == 96) 
        {
            string letter = "A";
            Console.WriteLine ($"{letter}");
            Console.WriteLine ("Congratulations! You passed the course.");
        }


        if (percentageNumber >= 87 || percentageNumber == 89)
        {
            string letter = "B";
            string sign = "+";
            Console.WriteLine ($"{letter}{sign}");
            Console.WriteLine ("Congratulations! You passed the course.");
        }
        else if (percentageNumber >= 80 && percentageNumber < 83)
        {
            string letter = "B";
            string sign = "-";
            Console.WriteLine ($"{letter}{sign}");
            Console.WriteLine ("Congratulations! You passed the course.");
        }
        else if (percentageNumber == 83 || percentageNumber == 84 || percentageNumber == 85 || percentageNumber == 86)
        {
            string letter = "B";
            Console.WriteLine ($"{letter}");
        }

    
        if (percentageNumber >= 77 && percentageNumber <=79)
        {
            string letter = "C";
            string sign = "+";
            Console.WriteLine ($"{letter}{sign}");
            Console.WriteLine ("Congratulations! You passed the course.");
        }
        else if (percentageNumber >= 70 && percentageNumber < 73)
        {
            string letter = "C";
            string sign = "-";
            Console.WriteLine ($"{letter}{sign}");
            Console.WriteLine ("Congratulations! You passed the course.");
        }
        else if (percentageNumber == 73 || percentageNumber == 74 || percentageNumber == 75 || percentageNumber == 76)
        {
            string letter = "C";
            Console.WriteLine ($"{letter}");
        }
        
        if (percentageNumber >= 67 && percentageNumber <=69)
        {
            string letter = "D";
            string sign = "+";
            Console.WriteLine ($"{letter}{sign}");
            Console.WriteLine ("Unfortunately, you did not pass the course. Better luck next time.");
        }
        else if (percentageNumber >= 60 && percentageNumber < 63)
        {
            string letter = "D";
            string sign = "-";
            Console.WriteLine ($"{letter}{sign}");
            Console.WriteLine ("Unfortunately, you did not pass the course. Better luck next time.");
        }
        else if (percentageNumber == 63 || percentageNumber == 64 || percentageNumber == 65 || percentageNumber == 66)
        {
            string letter = "D";
            Console.WriteLine ($"{letter}");
        }

        if (percentageNumber < 60)
        {
            string letter = "F";
            Console.WriteLine ($"{letter}");
            Console.WriteLine ($"You got an {letter}. You failed the course. You need to retake it!");
        }


        
         
        
    }
}