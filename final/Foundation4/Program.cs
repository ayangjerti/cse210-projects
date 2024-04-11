using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine("------Polymorphism with Exercise tracking------\nBy Edem offiong");
        Console.WriteLine();
        List<Activity> exerciseList = new List<Activity>();

        Running marathonRace = new Running("15th feb, 2021", 30, 12.6);
        Cycling obuduCyclingOpen = new Cycling("12th march, 2023", 30, 45.2);
        Swimming poolsideSwimFest = new Swimming("12th sept, 2024", 12, 8);

        exerciseList.Add(poolsideSwimFest);
        exerciseList.Add(obuduCyclingOpen);
        exerciseList.Add(marathonRace);

        foreach (Activity XEsize in exerciseList) 
        {
           Console.WriteLine(XEsize.GetSummary());
           Console.WriteLine();
        }



    }
}