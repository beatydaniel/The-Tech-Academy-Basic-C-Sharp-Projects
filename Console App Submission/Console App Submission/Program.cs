using System;

namespace Console_App_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the letter?");
            string letter = Console.ReadLine();
            bool isGuessed = letter == "u"; // is true if the typed letter is u
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }    
            do //does the loop after the first input
            {
                switch (letter)
                {
                    case "a":
                        Console.Write("You guessed a. Try again. ");
                        Console.WriteLine("Guess a letter?");
                        letter = Console.ReadLine();
                        break;
                    case "f":
                        Console.WriteLine("You guessed f. Try again. ");
                        Console.WriteLine("Guess a letter?");
                        letter = Console.ReadLine();
                        break;
                    case "u":
                        Console.WriteLine("You guessed u. Thats correct!");
                        isGuessed = true; //this stops the loop.
                        break;
                    default:
                        Console.WriteLine("Your Wrong. Try again. ");
                        Console.WriteLine("Guess a letter?");
                        letter = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed); //Starts the loop
            Console.Read();
        }
    }
}
