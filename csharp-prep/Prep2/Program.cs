using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is your percentage ?");
       string percentage = Console.ReadLine();
       int grade = int.Parse(percentage);
       string letter = "";

       if (grade >= 90)
       {
        letter = "A";
        
       }
       else if (grade >= 80)
       {
        letter = "B";
        
       }
       else if (grade >=70 )
       {
        letter = "C";
        
       }
       else if (grade >=60  )
       {
        letter = "D";
        
       }
       else 
       {
        letter = "F";
        
       }
        int lastDigit = grade % 10;
        string sign = "";
        if (letter != "F" && (lastDigit >= 7 || grade == 100))
        {
            sign = "+";
        }
        else if (lastDigit < 3 && grade != 100)
        {
            sign = "-";
        }

        // Handle exceptional cases: A+, F+
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

       if (grade >=70 )
       {
        Console.WriteLine("Congratulations you pass the class");
       }
        else
        {
            Console.WriteLine(" Try taking the Test again ");
        }
    }
}