using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> userGoals = new List<Goal>();
        bool Quit = false;
        while (Quit == false)
        {
            //place the points here
            Console.WriteLine("You have 0 points!\n");
            Console.WriteLine("Welcome select from \n Menu Options: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n  5. Record Event \n 6. Quit \nSelect a choice from the menu:");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    userGoals.Add(NewGoal());
                    break;
                case "2":
                    Console.WriteLine("The goals are: ");
                    foreach (Goal goal in userGoals)
                    {
                        goal.displayGoal();
                    }
                    break;
                case "3":
                    Console.WriteLine("What is the file name for your goal file?");
                    Filehandling fileSave = new Filehandling(Console.ReadLine());
                    fileSave.saveGoals(userGoals);
                    break;
                case "4":
                    Console.WriteLine("What is the file name for your goal file?");
                    Filehandling fileLoad = new Filehandling(Console.ReadLine());
                    userGoals.AddRange(fileLoad.loadGoals());
                    break;
                case "5":
                    Console.WriteLine("The goals are: ");
                    foreach (Goal goal in userGoals)
                    {
                        goal.displayGoal();
                    }
                    Console.WriteLine("What goals did you accomplish?");
                    int userChoice = int.Parse(Console.ReadLine());
                    userGoals[userChoice - 1].RecordEvent();
                    break;
                case "6":
                    Quit = true;
                    break;
            }
        }
    }
    static Goal NewGoal()
    {
        string goalName;
        string goalDesc;
        string goalPoints;

        Console.WriteLine("The types of Goals are: \nMenu Options: \n1. Simple Goal \n 2. Eternal Goal\n 3. Checklist Goal \nWhich type of Goal would you like to create?");
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                Console.Write("What is the name of your Goal?\n");
                goalName = Console.ReadLine();
                Console.Write("Write a short description of your goal.\n");
                goalDesc = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?\n");
                goalPoints = Console.ReadLine();
                Simple simple = new Simple(goalName, goalDesc, goalPoints);
                return simple;
                break;

            case "2":
                Console.Write("What is the name of your Goal?\n");
                goalName = Console.ReadLine();
                Console.Write("Write a short description of your goal.\n");
                goalDesc = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?\n");
                goalPoints = Console.ReadLine();
                Eternal eternal = new Eternal(goalName, goalDesc, goalPoints);
                return eternal;
                break;

            case "3":
                Console.Write("What is the name of your Goal?\n");
                goalName = Console.ReadLine();
                Console.Write("Write a short description of your goal.\n");
                goalDesc = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?\n");
                goalPoints = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus?\n");
                string goalChecks = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times?\n");
                string goalBonus = Console.ReadLine();
                Checklist checklist = new Checklist(goalName, goalDesc, goalPoints, goalChecks, goalBonus, "0");
                return checklist;
                break;
        }
    }
}