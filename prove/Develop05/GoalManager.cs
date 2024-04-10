// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // attributes if needed
    private List<Goal> _goals;
    private int _score;
    private string menu_choice;




    // getters
    public double GetScore()
    {
        return _score;
    }

    // methods

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    
    public void Start()
    {

        do 
        {
            
            Console.WriteLine();

            Console.WriteLine("WELCOME TO THE ETERNAL QUEST PROGRAM");
            Console.WriteLine("Menu Options: \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit ");
            Console.Write("Select a choice from the menu: ");
            menu_choice  = Console.ReadLine();

            
        
            if (menu_choice == "1")
            {
                CreateGoal();

            }

            if (menu_choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Available goals currently are:");
                ListGoalDetails();
            }

            if (menu_choice == "3")
            {
                SaveGoals();
            }

            if (menu_choice == "4")
            {
                LoadGoals();
            }

            if (menu_choice == "5")
            {
                RecordEvent();
            }

                
            
        }while(menu_choice != "6");
        Console.WriteLine("Thanks for having us.\nHave a nice day");

    }

    public void DisplayPlayerInfo()
    {
        
    }

    public void  ListGoalNames()
    {
        foreach (Goal gola in _goals)
        {
            Console.WriteLine(gola.GetName());
        }

    }


    public void ListGoalDetails()
    {
         foreach (Goal gola in _goals)
        {
            Console.WriteLine(gola.GetDetailsString());
        }
        
    }

    public void CreateGoal()
    {
         Console.WriteLine("What type of goal do you want to create?\n1. A simple Goal\n2. An eternal Goal\n3. A Checklist Goal"); 
        string userGoal = Console.ReadLine();
        if (userGoal == "1")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("Write a short description for this goal ");
            string goalDesc = Console.ReadLine();
            Console.Write("What amount of points is associated with this goal? ");
            string goalPoint = Console.ReadLine();
            int goalPointNum = int.Parse(goalPoint);
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDesc, goalPointNum);
            _goals.Add(simpleGoal);
        }
        else if (userGoal == "2")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("Write a short description for this goal ");
            string goalDesc = Console.ReadLine();
            Console.Write("What amount of points is associated with this goal? ");
            string goalPoint = Console.ReadLine();
            int goalPointNum = int.Parse(goalPoint);
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDesc, goalPointNum);
            _goals.Add(eternalGoal);
        }
        
        else
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("Write a short description for this goal ");
            string goalDesc = Console.ReadLine();
            Console.Write("What is the target of this goal? ");
            string goalTarget = Console.ReadLine();
            int goalTargetNum = int.Parse(goalTarget);
            Console.Write("What amount of points is associated with this goal? ");
            string goalPoint = Console.ReadLine();
            int goalPointNum = int.Parse(goalPoint);
            Console.Write("What bonus do you ascribe to this goal? ");
            string goalBonus = Console.ReadLine();
            int goalBonusNum = int.Parse(goalBonus);
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDesc, goalPointNum, goalTargetNum, goalBonusNum);
            _goals.Add(checklistGoal);
        }
    }

    public  void RecordEvent()
    {
        Console.WriteLine("What type of goal have you accomplished and would you like to record?");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal"); 
        string userPref = Console.ReadLine();
        if (userPref == "1")
        {
            Console.Write("What is the name of the goal? ");
            string goalname = Console.ReadLine();
            foreach (Goal gola in _goals)
            {
                if (gola is SimpleGoal && gola.GetName() == goalname)
                {
                    gola.RecordEvent();
                    _score +=  gola.GetPoints();
                }
            }
        }
        else if (userPref == "2")
        {
            Console.Write("What is the name of the goal? ");
            string goalname = Console.ReadLine();
            foreach (Goal gola in _goals)
            {
                if (gola is EternalGoal && gola.GetName() == goalname)
                {
                    gola.RecordEvent();
                    _score +=  gola.GetPoints();
                }
            }
        }
     
        else if (userPref == "3")
        {
            Console.Write("What is the name of the goal? ");
            string goalname = Console.ReadLine();
            foreach (Goal gola in _goals)
            {
                if (gola is ChecklistGoal && gola.GetName() == goalname)
                {
                    gola.RecordEvent();
                    _score +=  gola.GetPoints();
                    
                }
            }
        }
    }

    public void SaveGoals()
    {
         Console.Write("What would you like to save the file as? ");
        string userName = Console.ReadLine();
        userName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(userName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal gola in _goals)
            {
                outputFile.WriteLine(gola.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        
        Console.Write("What is the name of the file you would like to load? ");
        string userName = Console.ReadLine();
        userName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(userName);
        string scoreString = lines[0];
        _score = int.Parse(scoreString);
        foreach (string line in lines.Skip<string>(1))
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goalDetails = parts[1];
            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal("a", "b", 1);
                simpleGoal.CreateSimpleGoal(goalDetails);
                string[] objectParts = goalDetails.Split(",");
                if (objectParts[4] == "true")
                {
                    simpleGoal._isComplete = true;
                    _goals.Add(simpleGoal);
                }
                else
                {
                    _goals.Add(simpleGoal);
                }
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal("a", "b", 1);
                eternalGoal.CreateEternalGoal(goalDetails);
                _goals.Add(eternalGoal);
            }
         
            else
            {
                ChecklistGoal checklistGoal = new ChecklistGoal("a", "b", 1, 1, 1);
                checklistGoal.CreateChecklistGoal(goalDetails);
                _goals.Add(checklistGoal);
            }
        }
    }



    
}