using System;

class Program
{
    static void Main(string[] args)
    {
        //TestFunction();
        //Activity activity = new Activity("Breathing", "in&out");
        //activity.ShowStartMessage();
        //Console.Clear();

        bool Quit = false;
        while (Quit == false)
        {
            Console.WriteLine("Welcome select from \n Menu Options: \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listening activity \n 4. Quit \n Select a choice from the menu:");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BreathingActivity breathingObject = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.WriteLine("How long, in seconds, would you like for your session?");
                    breathingObject.SetDuration(int.Parse(Console.ReadLine()));
                    breathingObject.ShowStartMessage();
                    breathingObject.PauseWithSpinner();
                    breathingObject.Breathe();
                    breathingObject.ShowEndMessage();
                    break;

                case "2":
                    ReflectionActivity reflectionObject = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectionObject.ShowStartMessage();
                    Console.WriteLine("How long, in seconds, would you like for your session?");
                    reflectionObject.SetDuration(int.Parse(Console.ReadLine()));
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.ShowStartMessage();
                    Console.WriteLine("How long, in seconds, would you like for your session?");
                    listingActivity.SetDuration(int.Parse(Console.ReadLine()));
                    break;
                case "4":
                    Quit = true;
                    break;

            }
        }


    }
    //Test Functions
    static void TestFunction()
    {
        Activity activity = new Activity("", "");
        BreathingActivity breathingActivity = new BreathingActivity("", "");
        breathingActivity.Breathe();
    }

}