using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)

        {
      
            PromptGenerator prompts = new PromptGenerator();

            // populate the _prompts list in class
            prompts._prompts.Add("What is one thing you achieved today?");
            prompts._prompts.Add("What was the strongest emotion you felt today?");
            prompts._prompts.Add("Who was the most interesting person you interacted with today?");
            prompts._prompts.Add("What was the best part of your day?");
            prompts._prompts.Add("What was the best thing that happened to you today?");
            prompts._prompts.Add("What do you feel is your purpose in life, and has that answer changed in the last five years?");
            prompts._prompts.Add("Are you satisfied with how today went? Do you wish it went better?");
            prompts._prompts.Add("Did you meet anyone interesting today?");
            prompts._prompts.Add("If you could take back any of your actions, what would you take back from today?");
            prompts._prompts.Add("How disciplined have you been today? Are you making any progress?");
            prompts._prompts.Add("How have you impacted the lives you came across today?");


            Journal theJournal = new Journal();

            string userChoice;


            do
                {
                Console.WriteLine("Welcome to your Personal Journal");
                Console.WriteLine("Please select one of the following choices\n1. Write new entry\n2. Display\n3. Save\n4. Load\n5. Quit");
                Console.Write("What would you like to do??__");
                userChoice = Console.ReadLine();
                Console.WriteLine();

                if (userChoice == "1")
                {
                    Entry newEntry = new Entry();
                  
                    newEntry._promptText = prompts.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    Console.Write(">>>>>  ");
                    newEntry._entryText = Console.ReadLine();
                    Console.WriteLine();
                    DateTime theCurrentTime = DateTime.Now;
                    newEntry._date = theCurrentTime.ToShortDateString();
                    Console.Write("what is your mood today? ");
                    newEntry._mood = Console.ReadLine();
                    theJournal.AddEntry(newEntry);
                }

                if (userChoice == "2")
                {
                    theJournal.DisplayAll();
                }

                if (userChoice == "3")
                    {
                    Console.Write("What filename would you like to use? ");
                    string file = Console.ReadLine();
                    theJournal.SaveToFile(file);
                    }

                if (userChoice == "4")
                {
                    theJournal._entries.Clear();
                    Console.Write("What file do you want to load?");
                    string file = Console.ReadLine();
                    theJournal.LoadFromFile(file);
                }
            } while(userChoice != "5");


        }
}