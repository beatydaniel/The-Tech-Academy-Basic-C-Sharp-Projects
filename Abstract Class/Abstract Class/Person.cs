using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public abstract class Person //Created a Abstract Class
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName(); // this makes it so any class inherriting Person must have some sort of implementation as this.
    }
}
