using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcom();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcom()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string username, int squared)
    {
        Console.WriteLine($"{username}, the square of your number is {squared}");
    }
}