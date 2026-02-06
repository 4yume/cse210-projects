using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
            20
            )
    { }
    
    public void Run()
    {
        DisplayStartingMessage();

        int start = 0;

        while (start < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(3);
            start += 3;

            if (start < _duration)
            {
                Console.WriteLine();
                Console.Write("Breathe out... ");
                ShowCountDown(4);
                start += 4;
                Console.WriteLine();
            }
        }
        Console.WriteLine();

        DisplayEndingMessage();
    }
}