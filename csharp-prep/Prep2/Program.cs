using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

         Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
            if (percent == 100 || percent % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (percent >= 80)
        {
            letter = "B";
            if (percent % 10 >= 7)
            {
                sign = "+";
            }
            else if (percent % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (percent >= 70)
        {
            letter = "C";
            if (percent % 10 >= 7)
            {
                sign = "+";
            }
            else if (percent % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (percent >= 60)
        {
            letter = "D";
            if (percent % 10 >= 7)
            {
                sign = "+";
            }
            else if (percent % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (percent >= 0 && percent < 60)
        {
            letter = "F";
            // No sign for F grades
        }
        else
        {
            Console.WriteLine("Invalid percentage entered. Please enter a percentage between 0 and 100.");
            return; // Exit the program if an invalid percentage is entered
        }

        // Display both the grade letter and the sign in one print statement
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}