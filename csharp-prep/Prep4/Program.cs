using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        int mynumber = -1;
        while (mynumber != 0)
        {
            Console.WriteLine("Kindly input any number and enter '0' to complete adding to this list");
            string response = Console.ReadLine();
            mynumber = int.Parse(response);
            if (mynumber != 0)
            {
                numbers.Add(mynumber);
            }


        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum) / (float)numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }
        Console.WriteLine($"The max is: {max}");
        // Find the smallest positive number closest to zero
        int closestToZero = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < closestToZero)
            {
                closestToZero = number;
            }
        }
        if (closestToZero == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number closest to zero is: {closestToZero}");
        }

        // Sort the list of numbers
        numbers.Sort();
        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
    
}