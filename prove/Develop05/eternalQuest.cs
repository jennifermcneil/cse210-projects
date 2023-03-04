using System;
public class EternalQuest
{
    private int _totalPoints;
    private string _userName;
    List<Goal> userGoals = new List<Goal>();
    private DateTime _date;

    public EternalQuest(string userName)
    {

    }

    public void Menu()
    {
        bool Quit = false;
        while (Quit == false)
        {
            Console.WriteLine($"\nYou have {_totalPoints} points!\n");
            Console.WriteLine("Welcome select from \nMenu Options: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit \nSelect a choice from the menu:");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    Console.WriteLine("The goals are: ");
                    DisplayAllGoals();
                    break;
                case "3":
                    Console.WriteLine("What is the file name for your goal file?");
                    Filehandling fileSave = new Filehandling(Console.ReadLine());
                    fileSave.SaveGoals(userGoals, _totalPoints);
                    break;
                case "4":
                    Console.WriteLine("What is the file name for your goal file?");
                    Filehandling fileLoad = new Filehandling(Console.ReadLine());
                    userGoals.AddRange(fileLoad.LoadFile());
                    break;
                case "5":
                    Console.WriteLine("The goals are: ");
                    DisplayIncompleteGoals();
                    Console.WriteLine("What goal did you accomplish?");
                    int userChoice = int.Parse(Console.ReadLine());
                    _totalPoints += userGoals[userChoice - 1].RecordEvent();
                    Console.WriteLine($"You now have {_totalPoints} points!");
                    break;
                case "6":
                    Quit = true;
                    break;
            }
        }
    }

    public void AddGoal()
    {
        string goalName;
        string goalDesc;
        int goalPoints;
        int userInput;
        Console.Clear();
        Console.WriteLine("The types of Goals are: \nMenu Options: \n 1. Simple Goal \n 2. Eternal Goal\n 3. Checklist Goal \nWhich type of Goal would you like to create?");

        while (true)
        {
            userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput < 1 || userInput > 3)
            {
                Console.WriteLine("Out of option range!");
            }
            else
                break;
        }
        switch (userInput)
        {
            case 1:
                Console.Write("What is the name of your Goal?\n");
                goalName = Console.ReadLine();
                Console.Write("Write a short description of your goal.\n");
                goalDesc = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?\n");
                goalPoints = Convert.ToInt32(Console.ReadLine());
                Simple simple = new Simple(goalName, goalDesc, goalPoints);
                userGoals.Add(simple);
                break;

            case 2:
                Console.Write("What is the name of your Goal?\n");
                goalName = Console.ReadLine();
                Console.Write("Write a short description of your goal.\n");
                goalDesc = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?\n");
                goalPoints = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus?\n");
                int goalTarget = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times?\n");
                int goalBonus = Convert.ToInt32(Console.ReadLine());
                Eternal eternal = new Eternal(goalName, goalDesc, goalPoints, goalBonus, goalTarget);
                userGoals.Add(eternal);
                break;

            case 3:
                Console.Write("What is the name of your Goal?\n");
                goalName = Console.ReadLine();
                Console.Write("Write a short description of your goal.\n");
                goalDesc = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?\n");
                goalPoints = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for the goal to be completed?\n");
                goalTarget = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the bonus for completing the goal?\n");
                goalBonus = Convert.ToInt32(Console.ReadLine());
                // How many times does this goal need to be done every day?
                int goalFrequency = Convert.ToInt32(Console.ReadLine());
                // pass the target times into constructor
                Checklist checklist = new Checklist(goalName, goalDesc, goalPoints, goalTarget, goalBonus, 0);
                userGoals.Add(checklist);
                break;
        }
    }

    public void DisplayAllGoals()
    {
        Console.Clear();
        for (int i = 0; i < userGoals.Count(); i++)
        {
            List<string> goalString = userGoals[i].GetgoalInfo();
            Console.WriteLine($"{i + 1}. [{userGoals[i].GetIsComplete()}] {goalString[0]} ({goalString[1]})");
        }

    }

    public void DisplayIncompleteGoals()
    {
        Console.Clear();
        int counter = 1;
        foreach (Goal goal in userGoals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{counter}. {goal.GetgoalInfo()[0]}");
                counter++;
            }
        }
    }
}