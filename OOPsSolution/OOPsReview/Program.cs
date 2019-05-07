using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            console is a reference to a system static class
            static classes are used by typing the class name
            static classes do not store variable data
            static classes are used by everyone (so it is not private)
            methods of a static class will be placed after the object 'dot' operator
             */
            Console.WriteLine("Hello World");

            //create an instance of a non static class
            //if you create a declarative using just the class name then this is only a pointer that can hold an instance of the class
            myData aVariable = null;
            //current value of aVariable is null. It is just a pointer.
            myData twoVariable = new myData();
            //assign some height yo
            twoVariable.SetHeight(12);
            if (aVariable == null)
            { 
                Console.WriteLine("aVariable Doesn't got nothin in it.");
            }

            if (twoVariable == null)
            {
                Console.WriteLine("twoVariable Doesn't got nothin in it.");
            }
        }
    }
}
