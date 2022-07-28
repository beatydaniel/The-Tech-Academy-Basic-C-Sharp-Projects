using System;
using System.Collections.Generic;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            string[] animals = { "Dog", "Cat", "Bird", "Rabbit" }; // String Array
            Console.WriteLine("Please Enter a color: ");
            string color = Console.ReadLine();

            for (int i = 0; i < animals.Length; i++) //First loop
            {
                animals[i] = " The " + animals[i] + " is " + color;
            }

            for (int i = 0; i < animals.Length; i++) //Second loop 
            {
                Console.WriteLine("\n" + animals[i]);
            }
            Console.ReadLine();

            //Part 2

            bool trueorFalse = true;
            while (trueorFalse) //Infinite loop when true
            {
                Console.WriteLine("Hey!");
                trueorFalse = false; //ends loop by changing it to false
                Console.ReadLine();
            }

            //Part 3

            for (int i = 0; i < 2; i++) //Using the < operator
            {
                Console.WriteLine("This should print twice");
            }
            Console.ReadLine();

            for (int i = 0; i <= 3; i++) // Using the <= operator
            {
                Console.WriteLine("This should print four times");
            }
            Console.ReadLine();

            //Part 4

            List<string> names = new List<string>() { "Daniel", "Brian", "Hannah", "Steven" }; //String List

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nEnter a Name to find the location of Name in the Index");
            string name = Console.ReadLine(); ;
            bool trueorFalse2 = false;

            for (int j = 0; j < names.Count; j++) //Loop that indicates where in the list names is its index
            {
                if (names[j] == name)
                {
                    Console.WriteLine("\n" + name + " is found at index " + j + "\n");
                    trueorFalse2 = true;
                    break; //Stops the loop
                }
            }

            if (!trueorFalse2)
            {
                Console.WriteLine(name + " is not in the list.\n");
            }
            Console.ReadLine();

            //Part 5

            List<string> colors = new List<string>() { "Red", "Blue", "Blue", "Green", "Red", "Black" };  //Duplicate Entries 

            foreach (string i in colors)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nPlease Enter a Color to see its location\n");
            string color2 = Console.ReadLine();
            bool trueorFalse3 = false;

            for (int p = 0; p < colors.Count; p++)
            {
                if (colors[p] == color2)
                {
                    Console.WriteLine(color2 + " is found it at index: " + p + "\n"); // returns single or duplicate entries and displays there locations in the index.
                    trueorFalse3 = true;
                }
            }

            if (!trueorFalse3)
            {
                Console.WriteLine(color2 + " is not in the list");
            }
            Console.ReadLine();

            //Part 6

            List<string> movies = new List<string>() { "Avengers -", "Die Hard -", "Harry Potter -", "Alien -", "Terminator -", "Terminator -", "Alien -"};
            List<string> duplicates = new List<string>();

            Console.WriteLine("This is my list\n");

            foreach (string movie in movies)
            {
                if (duplicates.Contains(movie))
                {
                    Console.WriteLine(movie + " this item is a duplicate ");
                }
                else
                {
                    Console.WriteLine(movie + " this item is unique. "); //prints the list of movies
                    duplicates.Add(movie);
                }
            }
            Console.ReadLine();
        }
    }
}
