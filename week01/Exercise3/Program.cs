using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        
        

        Random randomGenerator = new Random(); int magicNumber =
        randomGenerator.Next(1,101);

        Console.WriteLine("Try to guess the magic number");

        int guess;

        do
        {
            Console.WriteLine("What is your guess?");
            string number2 = Console.ReadLine();
            guess = int.Parse(number2);

            if (guess == magicNumber)
            {
            Console.WriteLine("You guessed it!");
            }
            else if (guess < magicNumber)
            {
            Console.WriteLine("Higher");
            }
            else
            {
            Console.WriteLine("Lower");
            }

        } while (guess != magicNumber);
        
        
    }
}