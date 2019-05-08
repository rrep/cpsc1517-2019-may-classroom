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
        public int height;
        public int width;

        
        public int GetHeight()
        {
            return height;
        }

        public void SetHeight(int myDataHeight)
        {
            height = myDataHeight;
        }
       
    }
}
