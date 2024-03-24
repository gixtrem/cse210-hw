using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Umah Godday", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Umah Godday", "Fractions", "7.3", "5-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Umah Godday", "Humanities", "Lessons to be learned from Farhrenheit ");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}