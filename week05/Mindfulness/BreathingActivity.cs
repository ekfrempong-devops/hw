using System;
using System.Threading;

using System.ComponentModel;

public class BreathingActivity : Activity
{

public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
       
    }

public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);

            Console.WriteLine();
    
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
            DisplayEndingMessage();
    }
      
}