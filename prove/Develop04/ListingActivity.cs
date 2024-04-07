// ListingActivity.cs

public class ListingActivity : Activity
{
    // attributes
    
    List<string> items = new List<string>();

    protected int _count;

    protected List<string> _prompts = new List<string>();



    // methods/constructors
    public ListingActivity(string name, string description) :base(name, description)
    {
        // _count = 0;
        // _count= items.Count;\
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");


    }

   


    public void Run()
    {
        Console.WriteLine("List as many question as you can to the following prompt: ");
        string promptt = GetRandomPrompt();
        Console.WriteLine($"---{promptt}----");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        // GetRandomPrompt();
        // ShowCountDown(5);
        GetListFromUser();
        listcount();
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

    public void GetListFromUser()
    {
        

        // List<string> items = new List<string>();

        for (int i = 0; i < _duration; i++)
        {
            Console.Write($"Item {i + 1}: ");
            string listItem = Console.ReadLine();
            items.Add(listItem);
        }

        }

    public void listcount ()
    {
    Console.WriteLine($"You entered {items.Count} items:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }



}