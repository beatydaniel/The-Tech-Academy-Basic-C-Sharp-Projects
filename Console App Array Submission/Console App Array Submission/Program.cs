using System;
using System.Collections.Generic;

namespace Console_App_Array_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "Hello", "How", "Are", "You" }; // Creating a String Array

            Console.WriteLine("Please Select a index of the string array from 0 and 3 ");
            int strIndex = Convert.ToInt32(Console.ReadLine());
            if (strIndex <= 3) // if the user inputs any number between 0-3 do this
            {
                Console.WriteLine(stringArray[strIndex]); // Takes the information from the stringArray and the new stored value the user inputs.
            }
            else // if higher than 3 or anything else do this
            {
                Console.WriteLine("Sorry that is number is not part of the index please try again!\n");
                Console.WriteLine("Please Select a index of the string array from 0 and 3 ");
                int strIndex2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(stringArray[strIndex2]);
            }

            int[] intArray = new int[] { 3, 4, 5, 10 }; // Creating a int array

            Console.WriteLine("Please Select a index of the int array from 0 and 3");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            if (intIndex <= 3)
            {
                Console.WriteLine(intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Sorry that is number is not part of the index please try again!\n");
                Console.WriteLine("Please Select a index of the int array from 0 and 3 ");
                int intindex2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(intArray[intindex2]);
            }
            List<string> strList = new List<string>(); // Creates a List
            strList.Add("I"); //Adds to the list
            strList.Add("Love");
            strList.Add("C");
            strList.Add("#");

            Console.WriteLine("Please Select a index of the string list from 0 and 3");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex <= 3)
            {
                Console.WriteLine(strList[listIndex]);
            }
            else
            {
                Console.WriteLine("Sorry that is number is not part of the index please try again!\n");
                Console.WriteLine("Please Select a index of the string list from 0 and 3 ");
                int listIndex2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(strList[listIndex2]);
            }
        }
    }
}
