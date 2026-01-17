//Add entry number when display the all Entry

using System;

class Program
{
    static void Main(string[] args)
    {
        Jornal journal = new Jornal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userInput = "";

        //loop until user enter 5
        while (userInput != "5")
        {
            //display menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;

                journal.AddEntry(entry);
            }

            else if (userInput == "2")
            {
                journal.DisplayAll();
            }

            else if (userInput == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (userInput == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }

        
    }
}