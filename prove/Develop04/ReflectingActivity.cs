// RelectingActivity.cs

using System.Diagnostics;
using System.Collections.Generic; 

public  class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>
     {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };



    


    // constructors/relevant methods`

    // public ReflectingActivity()
    // {
    //     _prompts;
    //     _questions;
    // }
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        
    }  



    public string GetRandomPrompt()
    {
        Random random = new Random();
        if (_prompts == null || _prompts.Count == 0)
        {
            throw new ArgumentException("The list is null or empty.");
        }
        
        // Generate a random index
        int randomIndex = random.Next(0, _prompts.Count);

        // Return the item at the random indexx
        return _prompts[randomIndex];
        
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        if (_prompts == null || _prompts.Count == 0)
        {
            throw new ArgumentException("The list is null or empty.");
        }
        
        // Generate a random index
        int randomIndex = random.Next(0, _prompts.Count);

        // Return the item at the random indexx
        return _questions[randomIndex];
        
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        string promptt = GetRandomPrompt();
        Console.WriteLine($"----{promptt}---");
        Console.WriteLine();
        
    }


    public void DisplayQuestions()
    {
        // GetRandomQuestion();
        foreach (string question in _questions)
        {
            Console.Write($"{question}: ");
            // You can do something with the user's answers here
            ShowSpinner(5); // Pause for several seconds
        }

    }


        public void Run()
    {
        int i=0;
        Console.WriteLine("Running the reflecting activity...");
        Console.WriteLine();
        DisplayPrompt();
        // for (i=0, i=_duration, i++)

        while (i <= _duration)
            {
                DisplayQuestions();
        }
        
        
        
    }

}