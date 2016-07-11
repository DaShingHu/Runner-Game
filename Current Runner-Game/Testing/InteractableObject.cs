using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Testing
{
    abstract class InteractableObject
    {
        // Priority is largest numbers = last drawn

        public Bitmap selfImage;
        protected int x;
        protected int y;
        protected int priority;
        protected Boolean passThrough;

        //      abstract public void draw(Graphics g);
        //      abstract public int priorityValueIs();

        public InteractableObject(Image inputImage, Boolean isPass, int x, int y, int priority)
        {
            this.selfImage = new Bitmap(inputImage);
            passThrough = isPass;
            this.x = x;
            this.y = y;
        }

        public void setX(int input)
        {
            // Sets x value
            this.x = input;
        }
        public void setY(int input)
        {
            this.y = input;
        }
        public void setPriority(int input)
        {
            this.priority = input;
        }

        public void move(String direction)
        {
            // E = +1
            // W = -1
            // N = +1
            // S = -1
            if (direction == "E")
            {
                this.x++;
            }
            else if (direction == "W")
            {
                this.x--;
            }
            else if (direction == "N")
            {
                this.y--;
            }
            else if (direction == "S")
            {
                this.y++;
            }
        }
        public void pass()
        {
            this.passThrough = false;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
        public int getWidth()
        {
            return this.selfImage.Width;
        }
        public int getHeight()
        {
            return this.selfImage.Height;
        }
        public void draw(Graphics g)
        {
            g.DrawImage(this.selfImage, this.x, this.y);
        }
        public int priorityValueIs()
        {
            return this.priority;
        }
    }
}
