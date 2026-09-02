using System;
using System.Drawing;
using System.Windows.Forms;

namespace foto_movimento
{
    public partial class Form1 : Form
    {
        int contador = 0,
           deltaX = 1, 
           deltaY = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Largura = this.Size.Width,
               Altura = this.Size.Height - 25;

            int largura = bola.Size.Width,
                altura = bola.Size.Height;

            int x = bola.Location.X,
                y = bola.Location.Y;

            x = x + deltaX;
            y = y + deltaY;

            if ((x > (Largura - largura)) || (x < 0))
            {
                deltaX = -deltaX;
            }

            else
            {
                bola.Location = new Point(x, y);
            }

            if ((y > (Altura - altura)) || (y < 0))
            {
                deltaY = -deltaY;
            }

            else
            {
                bola.Location = new Point(x, y);
            }

        }
    }
}
