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
        //properties are associated with a single piece of data
        //a property has two subcomponents - get and set
        //get returns a value to the calling method (client)
        //the keyword used to represent incoming data is 'value'
        // a property DOES NOT TAKE a parameter
        private int _height;
        private int _width;

        

        public int GetHeight()
        {
            return _height;
        }

        public void SetHeight(int myDataHeight)
        {
            _height = myDataHeight;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int myDataWidth)
        {
            _width = myDataWidth;
        }
    }
}
