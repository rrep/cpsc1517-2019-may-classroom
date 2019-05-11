using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Gate
    {

        public double? Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Style { get; set; }

        //read-only property. Contains no set{}. data used in this property is data that is currently within the instance of this class.
        //this is a method that is created to call a specific property to reduce calculations required by the developers
        //this would be like a full name, or a formula
        public double GateArea
        {
            get
            {
                return Height*Width;
            }
        }


        public Gate() { }

        //here is an example of the constructor with parameters
        //this is called the "greedy" constructor
        public Gate(double height, double width, double? price, string style)
        {
            Height = height;
            Width = width;
            Price = price;
            Style = style;
        }
    }
}

