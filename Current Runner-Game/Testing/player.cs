using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Testing
{
    class Player : InteractableObject
    {

        //  public Player()
        // {
        // Default constructor
        //      self = new Bitmap(64, 64);
        //  }

        public Player(Image inputImage, int priority)
            : base(inputImage, false, 0, 0, priority)
        {
        }


        // This means to implement the method
        /*    public override void draw(Graphics g)
            {
                g.DrawImage(this.self, this.x, this.y);
            }
            public override int priorityValueIs()
            {
                return this.priority;
            }

            public void drawTwo(Graphics g)
            {
                g.DrawImage(this.self, this.x, this.y);
            }
         */
    }
}
