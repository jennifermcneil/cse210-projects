public class PromptGenerator
{
    public Random _generator = new Random();
    public List<string> prompts = new List<string>();

    public PromptGenerator()
    {
        prompts.Add("What was the best part of your day?");
        prompts.Add("What color do you feel like today and why?");
        prompts.Add("What is a dream you've had that you want to live in forever?");
        prompts.Add("Who is the most interesting person you can think of and why?");
        prompts.Add("What three things are you most grateful for?");
        prompts.Add("What values do you consider most important in life?");
        prompts.Add("What is the one thing about yourself that you would never change?");
    }
    public string GeneratePrompt()
    {
        return prompts[_generator.Next(prompts.Count)];
    }
}