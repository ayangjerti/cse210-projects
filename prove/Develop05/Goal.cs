// Goal.cs
using System;

public abstract class Goal
{
    // attributes

    private string _description;
    private int _points; 

    private string _shortname;


    // Methods and constructors

    public Goal(string name, string description, int points) //constructor
    {
        _shortname = name;
        _description = description;
        _points = points;
    }
    // setters and getters 
    public int SetPoints(int points)
    {
        return _points;
    }

    protected string SetName(string name){
        return _shortname;
    }

    protected string SetDescription(string description)
    {
        return _description;
    }


    public virtual string GetDescription()
    {
        return _description;
    }
    public int GetPoints(){
        return _points;
    }

     public string GetName(){
        return _shortname;
    }






    public abstract void RecordEvent();
   

    public abstract bool IsComplete();

    public virtual  string GetDetailsString()
    {
        if (IsComplete()==true)
        {
            return $"[x] {_shortname}: {_description}";
        }
        else
        {
            return $"[] {_shortname}: {_description}";
        }
    }

    public abstract string GetStringRepresentation();





}