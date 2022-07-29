using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
   public class Opertations
    {
        public int Operation(int awnser)  // Uses a integar.
        {
            return awnser + 10; // Gives the value that is from the main program and adds it by 10
        }
        public int Operation(decimal decimalNum)
        {
            int awnser = Convert.ToInt32(decimalNum) * 25; // Converts the decimal into a integer
            return awnser;
        }
        public int Operation(string number) // takes a string
        {
            int awnser = Convert.ToInt32(number) - 30; //converts the string into a integer
            return awnser;
        }
    }
}
