using System;

class Program
{
    static void Main(string[] args)
    {
        // //class objects that contains variables and methods
        // // (CLASS Type) (Object Name) = new (CLASS Constructor) == instance, (Object Name) == Class object.
        // Reference reference = new Reference("John", "16", "33");
        // string verse = "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world.";
        //Scripture scripture = new Scripture(reference, verse);

        //scripture.HideWords();
        string[] words = System.IO.File.ReadAllLines("myScripture.txt");


        string[] book;
        string[] chapter;
        string[] startVerse;
        string[] endVerse;

        foreach (string item in words)
        {
            book = item.Split("/");
            chapter = book[1].Split(":");
            startVerse = chapter[1].Split("-");
            endVerse = startVerse[0].Split("^");

            // new Reference(book[0], chapter[0], startVerse[0], endVerse[1]);

        }


        int userInput = 0;

        while (userInput != 5)
        {
            Console.WriteLine("Welcome, which scripture would you like to memorize?");
            Console.WriteLine("1. John 16:33");
            Console.WriteLine("2. D&C 5:34");
            Console.WriteLine("3. D&C 88:68");
            Console.WriteLine("4. D&C 11:12-13");
            Console.WriteLine("5. 2 Timothy 1:7");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                book = words[0].Split("/");
                chapter = book[1].Split(":");
                startVerse = chapter[1].Split("-");
                endVerse = startVerse[0].Split("^");


                Scripture scripture1 = new Scripture(new Reference(book[0], chapter[0], startVerse[0]), startVerse[1]);
                scripture1.DisplayNPrompt();
                scripture1.HideWords();
            }
            if (userInput == 2)
            {
                book = words[1].Split("/");
                chapter = book[1].Split(":");
                startVerse = chapter[1].Split("-");
                endVerse = startVerse[0].Split("^");

                Scripture scripture2 = new Scripture(new Reference(book[0], chapter[0], startVerse[0]), startVerse[1]);

                scripture2.DisplayNPrompt();
                scripture2.HideWords();
            }
            if (userInput == 3)
            {
                book = words[2].Split("/");
                chapter = book[1].Split(":");
                startVerse = chapter[1].Split("-");
                endVerse = startVerse[0].Split("^");

                Scripture scripture3 = new Scripture(new Reference(book[0], chapter[0], startVerse[0]), startVerse[1]);
                scripture3.DisplayNPrompt();
                scripture3.HideWords();
            }
            if (userInput == 4)
            {
                book = words[3].Split("/");
                chapter = book[1].Split(":");
                startVerse = chapter[1].Split("-");
                endVerse = startVerse[0].Split("^");


                Scripture scripture4 = new Scripture(new Reference(book[0], chapter[0], startVerse[0], endVerse[1]), startVerse[1]);
                scripture4.DisplayNPrompt();
                scripture4.HideWords();
            }
            if (userInput == 5)
            {
                book = words[4].Split("/");
                chapter = book[1].Split(":");
                startVerse = chapter[1].Split("-");
                endVerse = startVerse[0].Split("^");


                Scripture scripture5 = new Scripture(new Reference(book[0], chapter[0], startVerse[0]), startVerse[1]);
                scripture5.DisplayNPrompt();
                scripture5.HideWords();
            }

        }
    }
}
