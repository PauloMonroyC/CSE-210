//Exceeding requirements: Each journal entry also strores the user's mood
// at the time of writing, in addition to the date, prompt, and response.

using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();
        Journal theJournal = new Journal();

        bool running = true;

        while (running)

        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Dislplay the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {

                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                string response = Console.ReadLine();

                Console.Write("How are you feeling? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                theJournal.AddEntry(newEntry);


            }

            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("What file would you like to save to? ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }

            else if (choice == "4")
            {
                Console.Write("What file would you like to load from? ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);

            }

            else if (choice == "5")
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Not a valid option");
            }
        }













    }
}

