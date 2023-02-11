using System;

class Program
{
    static void Main(string[] args)
    {
        //string reference;
        Reference reference = new Reference("John", "16", "33");
        string[] verse = new string[1] { "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world." };
        Scripture scripture = new Scripture(reference, verse);

        // string scriptureText = "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world.";

        //class objects that contains variables and methods
        // (CLASS Type) (Object Name) = new (CLASS Constructor) == instance, (Object Name) == Class object.

        //Scripture scripture = new Scripture(reference, scriptureText);
        // Console.WriteLine(scripture.GetReferenceText());
        // Console.WriteLine(scripture.GetWord());
        // Console.WriteLine(scripture.GetwordObj());
    }
}