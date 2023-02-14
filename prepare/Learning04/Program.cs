using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John", "Math");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("addition", "1-5", "Susan", "Math");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        WritingAssignment writingAssignment = new WritingAssignment("I love Lucy", "Eric", "English");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }


}