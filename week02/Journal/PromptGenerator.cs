using System;

public class PromptGenerator
{
    List<string> _prompts = new List<string>
    {
        "What did you learn today?",
        "What do you want to do better tomorrow?",
        "What made you feel gratitude today?",
        "Who made you feel happy today and how?",
        "What is the best thing that happened to you today?"

    };

    Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}