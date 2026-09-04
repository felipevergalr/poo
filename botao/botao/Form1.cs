using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Claro que você aceita!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
        
            Random rand = new Random();


            int jumpX = rand.Next(20, 70);
            int jumpY = rand.Next(20, 70);

           
            int newLeft = button2.Left;
            int newTop = button2.Top;

            if (rand.Next(0, 2) == 0)
            {
                newLeft = newLeft + jumpX; 
            }
            else
            {
                newLeft = newLeft - jumpX; 
            }


            if (rand.Next(0, 2) == 0)
            {
                newTop = newTop + jumpY; 
            }
            else
            {
                newTop = newTop - jumpY; 
            }

            int maxLeft = this.ClientSize.Width - button2.Width;
            int maxTop = this.ClientSize.Height - button2.Height;

            if (newLeft < 0) 
                newLeft = 0;
            if (newLeft > maxLeft)
                newLeft = maxLeft;

            if (newTop < 0) 
                newTop = 0;

            if (newTop > maxTop) 
                newTop = maxTop;

            button2.Location = new Point(newLeft, newTop);
        }
    }
    
}
