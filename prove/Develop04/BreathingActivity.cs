// BreathingActivity.cs

public class BreathingActivity : Activity
{

    // no member attributes 


    // however there's methodds and constructors 
    public BreathingActivity(string name, string description) : base(name, description)
    {
        // return DisplayStartMessage()
    }

    public void Run()
    {
        // base.Run();
        Console.WriteLine("Running the breathing activity...");
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3); // Pause for several seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(3); // Pause for several seconds
    }

    }

}