using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine("Inheritance with Event Planning");
        Console.WriteLine();

        // Create addresses for reference
        Address receptionaddress = new Address("25 Mt. zion Lane", "Calabar", "CRS", "Nigera");
        Address lectureaddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address anotheradress = new Address("197 Richie St", "SMallville", "Idaho", "USA");
        
        // Create  at least one event of each type and sets all of their values 
        Receptions sponsioreception = new Receptions("Dr. Ayang's Sponsio reception", "We're celebrating with Dr. Ayang on becoming a medical doctor today", "15th september, 2023", "1PM GMT", receptionaddress, "fredoffizil@gmail.com");
        Lectures wddlecture = new Lectures("WDD 230 DOM lecture","A lecture on DOM manipulation usuing Javascript","Mattew Bessey", "15th feb, 2024", "12 seats only", "12PM MST", lectureaddress );
        OutdoorGathering pathwaygathering = new OutdoorGathering("Week5 gathering", "Weekly BYU pathway students gathering for academic and spiritual interaction","12th, march, 2021","4PM WAT", anotheradress, "Weather is predicted to be clear and sunny, minial thunderclouds in site" );

        //  call each of the methods to generate the marketing messages
        GenerateMarketingData(pathwaygathering);
        GenerateMarketingData(wddlecture);
        GenerateMarketingData(sponsioreception);




        
    }

    static void GenerateMarketingData(Event eventInstance)
    {
        Console.WriteLine("-------- EVENT CARD --------");
        Console.WriteLine();



        Console.WriteLine("Short Description:");
        Console.WriteLine(eventInstance.ShortDescription());
        Console.WriteLine();

      
        Console.WriteLine("Standard details:");
        Console.WriteLine(eventInstance.GetStandardDetails());
        Console.WriteLine();
        

        Console.WriteLine("Full Details:");
        Console.WriteLine(eventInstance.GetFullDetails());
        Console.WriteLine();
        
        
    }
}