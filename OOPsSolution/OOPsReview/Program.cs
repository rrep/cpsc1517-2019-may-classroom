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
             
            Console.WriteLine("Hello World");

            //create an instance of a non static class
            //if you create a declarative using just the class name then this is only a pointer that can hold an instance of the class
            FencePanel aVariable = null;
            //current value of aVariable is null. It is just a pointer.
            FencePanel twoVariable = new FencePanel(10, 10, 50, "weird");
            Console.WriteLine(twoVariable.GetWidth());
            Console.WriteLine(twoVariable.Price);
            Console.WriteLine(twoVariable.Style);
            //assign some height yo
            twoVariable.SetHeight(12);
            twoVariable.SetWidth(10);
            if (aVariable == null)
            { 
                Console.WriteLine("aVariable Doesn't got nothin in it.");
            }

            if (twoVariable == null)
            {
                Console.WriteLine("twoVariable Doesn't got nothin in it.");
            }
            */
            //using instances of classes

            FencePanel twoVariable = new FencePanel(10, 10, 50, "weird");
            string menuItem = "0";

            FenceEstimate CustomerFence = new FenceEstimate();
            CustomerFence.Fence = twoVariable;
            CustomerFence.Gates = new List<Gate>();
            Gate newGate = new Gate();
            do
            {
                Console.WriteLine("Please enter height:");
                string inputValue = Console.ReadLine();
                newGate.Height = int.Parse(inputValue);

                Console.WriteLine("Please enter width:");
                inputValue = Console.ReadLine();
                newGate.Width = int.Parse(inputValue);

                Console.WriteLine("Please enter style:");
                inputValue = Console.ReadLine();
                newGate.Style = inputValue;

                Console.WriteLine("Please enter price:");
                inputValue = Console.ReadLine();
                if (string.IsNullOrEmpty(inputValue))
                { newGate.Price = null; }
                else
                { newGate.Price = double.Parse(inputValue); }
                

                Console.WriteLine("Another Gate? (Y/N)");
                Console.ReadLine();
                //ternary operators
                //they are basically if statements that do not contain the if/else syntax.
                //syntax:  condition ? truevalue : falsevalue - only works if it is resolving into a true or false
                //ternary operators can be nested as long as it resolves to a single value.

                menuItem = inputValue.ToUpper().Equals("Y") ? "1" : "0";


                CustomerFence.Gates.Add(newGate);
                

            } while (menuItem != "0");

           
            Console.WriteLine("Please enter the fence length:");
            string newInputValue = Console.ReadLine();
            double linearLength = double.Parse(newInputValue);

            double NumberOfPanels = CustomerFence.Fence.EstimatedNumberOfPanels(linearLength);
            double FencePrice = Math.Ceiling(NumberOfPanels) * double.Parse(CustomerFence.Fence.Price.ToString());
            double gateCost = 0.0;
            foreach (var item in CustomerFence.Gates)
            {
                gateCost += double.Parse(item.Price.ToString());
            }

            Console.WriteLine("Total Fence Estimate");
            Console.WriteLine("Number of panels " + NumberOfPanels.ToString());
            Console.WriteLine("Cost of panels " + gateCost.ToString());
            //Console.WriteLine("Total:" + 

            Console.ReadKey();
        }
    }
}
