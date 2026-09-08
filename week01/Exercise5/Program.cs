using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName (string userName)
    {
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber (int userNumber)
    {
        Console.Write("Please enter your favorite number:");
        string number = Console.ReadLine();
        int numb = int.Parse(number);

        return numb;
    }

    static int SquareNumber (int number)
    {
        int sq = number * number;
        return number;

    }

    static void DisplayResult (int sq, string name)
    {
        Console.WriteLine ($"{name}, the square of your number is {sq}");
    }

}