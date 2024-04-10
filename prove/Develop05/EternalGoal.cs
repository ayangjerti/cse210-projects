// EternalGoal.cs
using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    // attributes

    // methods
    public EternalGoal(string name, string description, int points) : base(name, description, points) // constructor
    {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations!!\nYou have completed this goal\nYou have earned {GetPoints()}");
    }
   

    public override bool IsComplete()
    {
        return false;
    }

     public override string GetStringRepresentation()
    {
        return $"EternalGoal:[],{GetName()},{GetDescription()},{GetPoints()}";
    }

    public void CreateEternalGoal(string list)
    {
        string[] objectParts = list.Split(",");
        SetName(objectParts[1]);
        SetDescription(objectParts[2]);
        string pointsString = objectParts[3];
        int pointsNum = int.Parse(pointsString);
        SetPoints(pointsNum);
    }



    
}