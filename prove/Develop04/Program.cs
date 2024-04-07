using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        int navChoice = -1;

        
        // Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Welcome to the Mindfulness Program by Ayang Jhetem");
        Console.WriteLine();
        Console.WriteLine("Menu Options: \n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit.");
        Console.Write("Select a choice from the above menu:  ");
        navChoice = Convert.ToInt32(Console.Read());

        while(navChoice != 4)
        {
            if (navChoice == 1)
            {
                string name_B = "Breathing Activity";
                string desc_B = "relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing";
                BreathingActivity breathingactivity = new BreathingActivity(name_B,desc_B);
                breathingactivity.DisplayStartMessage();
                breathingactivity.Run();
                breathingactivity.DisplayEndingMessage();
              
                breathingactivity.ShowSpinner(10);
                
                            
            }

            if (navChoice == 2)
            {
                string name_L = "Listing Activity";
                string desc_L = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listingActivity = new ListingActivity(name_L, desc_L);
                listingActivity.DisplayStartMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }

            if (navChoice == 3)
            {
                string name_R = "Reflecting activity";
                string desc_R = "reflect on times in your life when you have shown stregth and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
                ReflectingActivity reflectingActivity = new ReflectingActivity(name_R, desc_R);
                reflectingActivity.DisplayStartMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();

            }

            else{
                
            }
        }

        
        



































    }
    
}