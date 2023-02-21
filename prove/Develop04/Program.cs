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
                    BreathingActivity breathingObject = new BreathingActivity("Breathing Activity", "\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingObject.ShowStartMessage();
                    breathingObject.PauseWithSpinner(5);
                    breathingObject.Breathe();
                    breathingObject.ShowEndMessage();
                    break;

                case "2":
                    ReflectionActivity reflectionObject = new ReflectionActivity("Reflection Activity", "\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectionObject.ShowStartMessage();
                    reflectionObject.PauseWithSpinner(5);
                    reflectionObject.Reflect();
                    reflectionObject.ShowEndMessage();
                    break;

                case "3":
                    ListingActivity listingObject = new ListingActivity("Listing Activity", "\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingObject.ShowStartMessage();
                    listingObject.PauseWithSpinner(5);
                    listingObject.Listing();
                    listingObject.DisplayCounter();
                    listingObject.ShowEndMessage();
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