//adding activity count

using System;

class Program
{
    static void Main(string[] args)
    {
        //creativity
        int activityCount = 0;

        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu(1-4): ");

            string answer = Console.ReadLine();
            Console.Clear();

            if (answer == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                activityCount++;
            }
            else if (answer == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                activityCount++;
            }
            else if (answer == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                activityCount++;
            }
            else if (answer == "4")
            {
                running = false;
                Console.WriteLine();
                Console.WriteLine($"You completed {activityCount} activities.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}