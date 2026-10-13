// Creativity requirement: the program includes a level system.
// Every 1,000 points increases the player's displayed level.
using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}