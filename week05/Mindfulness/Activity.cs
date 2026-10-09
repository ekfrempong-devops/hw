using System;
using System.Threading;
public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Get ready...");ShowSpinner(3);
        Console.WriteLine();
    }

public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");

        ShowSpinner(3);
    }

public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);   
            Console.Write("\b \b");
        }
        
        Console.WriteLine();
    }

public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }   
    }
}