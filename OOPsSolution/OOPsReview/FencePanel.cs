using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{

    //the default access permission is private
    //if an outside user of this class wanted access to the class contents, then the access permissions need to be public.
    //if the class was static, the class would not hold data. It would just be a set of methods that do not change.
    //for a class to hold data, do not make it static, unless you want everyone to be able to access it (rw)
    public class FencePanel
    {

        //constructor(s) are executed for the client caller during the execution of the "new" command
        //the client caller DOES NOT call a constructor directly
        //if no constructors are coded in a class definition, then the data storage within the class definition is set to the system defaults (string is null, numerics are 0, and bool is false)
        //if one codes a constructor within the class definition then the coder must code all constructors
        
        //here is the default constructor
        public FencePanel()
        {
            //optionally you may wish to have your own default values for your data storage items
        }

        //here is an example of the constructor with parameters
        //this is called the "greedy" constructor
        public FencePanel(double height, double width, double? price, string style)
        {
            _height = height;
            _width = width;
            Price = price;
            Style = style;
        }


        //properties are associated with a single piece of data
        //a property has two subcomponents - get and set
        //get returns a value to the calling method (client)
        //the keyword used to represent incoming data is 'value'
        // a property DOES NOT TAKE a parameter
        private double _height;
        private double _width;

        
   
        public double GetHeight()
        {
            return _height;
        }

        public void SetHeight(double myDataHeight)
        {
            _height = myDataHeight;
        }

        public double GetWidth()
        {
            return _width;
        }

        public void SetWidth(double myDataWidth)
        {
            _width = myDataWidth;
        }

        //fully implemented property
        private string _Style;

        //a nullable numeric (xxx?) will contain either a null or a number, therefore nullable numerics do not need to be fully implemented unless you have additional criteria to cover.
        public double? Price { get; set; }

        public string Style
        {
            get
            {
                return _Style;
            }
            set
            {
                //value contains the incoming data to the property
                //the contents of value needs to be stored
                //criteria: DO NOT store an empty string. store either null or the characters in the string
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }

        //behaviour - these are methods for the class
        public double EstimatedNumberOfPanels(double linearLength)
        {
            double numberOfPanels = linearLength / GetWidth();
            return numberOfPanels;
        }
    }
}
