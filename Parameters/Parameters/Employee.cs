using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters
{
    public class Employee <T> //Generic parameter
    {
        public List<T> things { get; set; }
    }
}
