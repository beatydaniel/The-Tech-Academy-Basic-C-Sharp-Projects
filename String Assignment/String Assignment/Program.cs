using System;
using System.Text;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "\"Hello how are you\"the man said.\n ";
            string name = "Daniel: ";
            string awnser = "I am well ";
            string speach = quote + name + awnser; // Combines the strings into one.

            speach = speach.ToUpper(); //makes the string speach Uppercased

            StringBuilder sb = new StringBuilder(); //builds a paragraph of text one sentence at a time.
            sb.Append("Hello my name is Daniel ");
            sb.Append("How are you ");

            Console.WriteLine(speach);
            Console.ReadLine();
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
