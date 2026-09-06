using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        


        Console.WriteLine("What is your percentage?");
        string percentage = Console.ReadLine();

        int number = int.Parse(percentage);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
         else if (number >= 60)
        {
            letter = "D";
        }
         else 
        {
            letter = "F";
        }

/*      int lastDigit = number % 10; 

        string sign = "";
        {
            if (letter != "F")
            {
                if (lastDigit >= 7)
            {
            sign = "+";
            }
            else if (lastDigit < 3)
            {
            sign = "-";
            }
        }

    Console.WriteLine($"Your grade is {letter}{sign}.");
*/
        Console.WriteLine($"Your grade is {letter}");
        

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }

        else 
        {
            Console.WriteLine("Unfortunatelly you did not passed the class! Try next time.");
        }

    }
}