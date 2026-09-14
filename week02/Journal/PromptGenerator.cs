using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","Have you thought of someone special today?","What was the first thing you did today?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];     
    }
}

