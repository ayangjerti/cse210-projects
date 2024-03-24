using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    // Create a new list of prompts
    public List<string> _prompts = new List<string>(); // left empty since classes are reallly just templates and thers no need to poulate the template

 
    // Method to get a random item from a list
    public string GetRandomPrompt()
    {
        // Create a Random instance
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
}
