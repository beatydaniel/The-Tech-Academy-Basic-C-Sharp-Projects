using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Method
{
    public class Integers
    {
       public int Add(int number) //Method - Adds the input by the methods value
        {
            int awnser = number + 100;
            return awnser;
        } 
        public int Subtraction(int number) //Method - Subtracts by using the input by the methods value
        {
            int awnser = number - 50;
            return awnser;
        }
        public int Multiply(int number) //Method - Multiplies the input by the methods value
        {
            int awnser = number * 20;
            return awnser;
        }
    }
}
