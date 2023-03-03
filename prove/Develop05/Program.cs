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
//For the Develop04 assignment, there are a couple things I want you to be aware of:

// You need to use polymorphism on this assignment.  (Hint on how to do this is below)
// In my opinion, the assignment is not particularly hard, but there is a lot of code that needs to be written.  Give yourself time to write it.
// Don't forget to test small pieces as you go.  I suggest that you start with the polymorphism piece and then add functions to each of the child classes as you go.  Write the same class for all the child classes and then test that function for everyone to make sure you get the expected polymorphic behavior.  The last thing you want is to write three classes and then realize you never did any polymorphism and you have to change everything.
// Polymorphism Hint
// For polymorphism, C# will not allow you to make a list of things with many different types.  However, you can make a list of a base class type and have that list hold objects of child class types.  So if I have a base class BaseClass and child classes A, B, and C, I can do the following:

// List<BaseClass> myObjectList = new List<BaseClass>();
// myObjectList.Add(new A());
// myObjectList.Add(new B());
// myObjectList.Add(new C());

// However, you won't be able to simply access any specialized attributes or methods of the child classes that are not defined by the base class.  The compiler can't be certain that those things exist if they are not part of the base class.  Why is this useful?  Because the way that classes work, when you override a function, that information is put in something called a virtual method table.  So suppose that the BaseClass has a method Foo() and A, B, and C all override Foo.  This means that if you do myObjectList[0].Foo(), you will get A's version of Foo that will use the data in the A-type object at index 0.  If you do myObjectList[1].Foo(), you will get B's version of Foo using the data in the B-type object at index 1.  If you do myObjectList[2].Foo(), you will get C's version of Foo using the data in the C-type object at index 2.