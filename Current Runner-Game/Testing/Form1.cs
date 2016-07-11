using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form1 : Form
    {
        Game newGame;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
            this.Focus();
            this.KeyPress += new KeyPressEventHandler(KeyPressingMethod);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyPressingMethod(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (newGame.isOver)
                {
                    btnExit.Visible = true;
                    newGame.gameOver();
                }
                else
                    newGame.move(Char.ToUpper(e.KeyChar).ToString());
            }//newGame.draw();
            e.Handled = true;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            newGame = new Game(picBox);
            btnStart.Visible = false;
            btnExit.Visible = false;
            lblTitle.Visible = false;
            picBox.Visible = true;
            this.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
