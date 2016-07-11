using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Testing
{
    class Item : InteractableObject
    {
        //   public Item ()
        //  {
        //      // Default constructor
        //      self = new Bitmap(64, 64);
        //   }
        public Item(Image inputImage, int priority)
            : base(inputImage, true, 0, 0, priority)

        {

        }

    }
}
