using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //call GetSummary method and display it
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        //create new MathAssignment object and set its value
        //call both the GetSummary and the GetHomeworkList methods
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fraction", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        //create new WritingAssignment object and set its value
        // call GetWritingInformation
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}