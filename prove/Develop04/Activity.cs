// Activity.cs
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected int GetDurationFromUser()
    {
        Console.Write("How long in seconds do you want this exercise to last?\nEnter the duration in seconds: ");
        _duration = Convert.ToInt32(Console.Read());
        // while (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
        // {
        //     Console.WriteLine("Invalid input. Please enter a positive integer for the duration.");
        //     Console.Write("How long in seconds do you want this exercise to last?\nEnter the duration in seconds: ");
        // }
        return _duration;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = GetDurationFromUser();
        
    }


       public void DisplayStartMessage()
    {

        Console.WriteLine($"Welcome to the {_name} \n This activity will help you {_description}. How long in seconds, would you you like for your session? ");
        _duration = GetDurationFromUser();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
    }

     public void DisplayEndingMessage()
     {
        Console.WriteLine($"Well dome !!!\nYou have completeted another {_duration} of {_name}.");
        Console.WriteLine("Thank you very for your time, i trust you feel good after practicing some mindfulness with our mindfulness program. We hope to see you next time");
     }

     public void ShowSpinner( int seconds)
    {
        
        
        List<string> animSpina = new List<string>();
        animSpina.Add("|");
        animSpina.Add("/");
        animSpina.Add("-");
        animSpina.Add("\\");
        animSpina.Add("|");
        animSpina.Add("/");
        animSpina.Add("-");
        animSpina.Add("\\");
        animSpina.Add("|");
        animSpina.Add("/");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int i = 0;

        while (start < end)
        {
            string s = animSpina[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i>=animSpina.Count)
            {
                i = 0;
            }
        
        }
        
   
    }

     public void ShowCountDown(int seconds)
     {
        
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i} seconds remaining.");
            Thread.Sleep(1000); // Sleep for 1 second
        }
     }







}