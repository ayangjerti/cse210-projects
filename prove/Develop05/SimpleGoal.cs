// SimpleGoal.cs
using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    

    // attributes
    public bool _isComplete = false;

    
    
    public SimpleGoal(string name, string description, int points) : base(name,description, points) // constructor
    {
        _isComplete = false;
    }
    // methods/responsibilities
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations!! \nYou have completed this goal\nYou just earned {GetPoints()}");
    }
   

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else{
            
            return false;
        }
    }

     public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            return $"SimpleGoal:[x],{GetName()},{GetDescription()},{GetPoints()},true";
        }
        else 
            {
                return $"SimpleGoal:[],{GetName()},{GetDescription()},{GetPoints()},true";
            }
    }

    public void CreateSimpleGoal(string list)
    {
        string[] objectParts = list.Split(",");
        SetName(objectParts[1]);
        SetDescription(objectParts[2]);
        string pointsString = objectParts[3];
        int pointsNum = int.Parse(pointsString);
        SetPoints(pointsNum);  
    }
    
}