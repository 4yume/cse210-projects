using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int answer = -1;
        while (answer != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            answer = int.Parse(Console.ReadLine());

            if (answer != 0)
            {
                numbers.Add(answer);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest is: {largest}");
    }
}