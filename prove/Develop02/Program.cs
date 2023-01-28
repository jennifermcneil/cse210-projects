using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int userInput = 0;
        FileHandling fileHandling = new FileHandling();

        while (userInput != 5)
        {
            Console.WriteLine("Welcome to your Journal!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                myJournal.Write();

            }
            if (userInput == 2)
            {
                myJournal.Display();
            }
            if (userInput == 3)
            {
                fileHandling.Save(myJournal._entryList);
            }
            if (userInput == 4)
            {
                fileHandling.LoadFile(myJournal._entryList);
            }
        }
    }
}