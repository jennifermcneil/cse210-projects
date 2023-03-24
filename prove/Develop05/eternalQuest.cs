using System;
using System.IO;
public class EternalQuest
{
    private int _totalPoints;
    private string _userName;
    List<Goal> userGoals = new List<Goal>();

    public EternalQuest(string userName)
    {
        _userName = userName;
    }

    public void Menu()
    {
        bool Quit = false;
        while (Quit == false)
        {
            Console.WriteLine($"\n{_userName}, You have {_totalPoints} total points!\n");
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
                    string filename = Console.ReadLine();
                    using (StreamWriter streamWriter = new StreamWriter(filename, true))
                    {
                        streamWriter.WriteLine(_totalPoints);
                    }
                    Console.WriteLine("What is the file name for your goal file?");
                    filename = Console.ReadLine();
                    string[] lines = File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        string[] data = line.Split("|");
                        if (data[0] == "Simple")
                        {
                            Simple simple = new Simple(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]));
                            userGoals.Add(simple);
                        }
                        else if (data[0] == "Eternal")
                        {
                            Eternal eternal = new Eternal(data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
                            userGoals.Add(eternal);
                        }
                        else if (data[0] == "Checklist")
                        {
                            Checklist checklist = new Checklist(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7]));
                            userGoals.Add(checklist);
                        }
                        else
                            _totalPoints = int.Parse(data[0]);
                    }
                    break;
                case "5":
                    Console.WriteLine("The goals are: ");
                    DisplayAllGoals();
                    Console.WriteLine("What goal did you accomplish?");
                    int userChoice = int.Parse(Console.ReadLine());
                    _totalPoints += userGoals[userChoice - 1].RecordEvent();
                    Console.WriteLine($"{_userName} You now have {_totalPoints} total points!");
                    break;
                case "6":
                    Quit = true;
                    break;
            }
        }
    }

    public void AddGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are: \nMenu Options: \n 1. Simple Goal \n 2. Eternal Goal\n 3. Checklist Goal \nWhich type of Goal would you like to create?");
        int userInput = int.Parse(Console.ReadLine());
        while (true)
        {
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
                Simple simple = new Simple();
                userGoals.Add(simple);
                break;

            case 2:
                Eternal eternal = new Eternal();
                userGoals.Add(eternal);
                break;

            case 3:
                Checklist checklist = new Checklist();
                userGoals.Add(checklist);
                break;
        }
    }

    public void DisplayAllGoals()
    {
        Console.Clear();
        for (int i = 0; i < userGoals.Count(); i++)
        {
            userGoals[i].GetGoalInfo(i);

        }

    }

    public void DisplayIncompleteGoals()
    {
        Console.Clear();
        int counter = 1;
        for (int i = 0; i < userGoals.Count(); i++)
        {
            if (!userGoals[i].IsComplete())
            {
                userGoals[i].GetGoalInfo(counter);
                counter++;
            }

        }
    }
}