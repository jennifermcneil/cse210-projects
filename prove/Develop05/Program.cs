using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        //Console.Clear();
        Console.WriteLine("Enter your name: ");
        userName = Console.ReadLine();
        EternalQuest eternalQuest = new EternalQuest(userName);
        Console.Clear();
        eternalQuest.Menu();

    }
}