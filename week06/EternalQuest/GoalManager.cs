
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine($"Your level is {_score / 1000 + 1}.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine($"Your level is {_score / 1000 + 1}.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

public void ListGoalDetails()
{
    Console.WriteLine();
    Console.WriteLine("The goals are:");

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    Console.WriteLine();
    Console.WriteLine($"You have {_score} points.");
}

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == 2)
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal =
                new ChecklistGoal(name, description, points, target, bonus);

            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Goal not created.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record.");
            return;
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[choice - 1];

        if (goal.IsComplete())
        {
            Console.WriteLine("This goal is already complete.");
            return;
        }

        bool wasComplete = goal.IsComplete();

        goal.RecordEvent();

        _score += goal.GetPoints();

        ChecklistGoal checklist = goal as ChecklistGoal;

        if (checklist != null)
        {
            if (!wasComplete && checklist.IsComplete())
            {
                _score += checklist.GetBonus();
                Console.WriteLine($"Congratulations! You earned a {checklist.GetBonus()} point bonus!");
            }
        }

        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
        DisplayPlayerInfo();
    }

    
public void SaveGoals()
{
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        outputFile.WriteLine(_score);

        for (int i = 0; i < _goals.Count; i++)
        {
            outputFile.WriteLine(_goals[i].GetStringRepresentation());
        }
    }

    Console.WriteLine("Goals saved successfully.");
}

    
public void LoadGoals()
{
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    string[] lines = File.ReadAllLines(filename);

    _score = int.Parse(lines[0]);
    _goals.Clear();

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split('|');

        if (parts[0] == "Simple")
        {
            SimpleGoal goal = new SimpleGoal(
                parts[1],
                parts[2],
                int.Parse(parts[3]));

            goal.SetComplete(bool.Parse(parts[4]));
            _goals.Add(goal);
        }
        else if (parts[0] == "Eternal")
        {
            EternalGoal goal = new EternalGoal(
                parts[1],
                parts[2],
                int.Parse(parts[3]));

            _goals.Add(goal);
        }
        else if (parts[0] == "Checklist")
        {
            ChecklistGoal goal = new ChecklistGoal(
                parts[1],
                parts[2],
                int.Parse(parts[3]),
                int.Parse(parts[5]),
                int.Parse(parts[6]));

            goal.SetAmountCompleted(int.Parse(parts[4]));
            _goals.Add(goal);
        }
    }

    Console.WriteLine("Goals loaded successfully.");
}
}