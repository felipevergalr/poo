using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cara_coroa
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int escolhaUsuario; // 0 = cara, 1 = coroa
        int resultado;
        bool mostrarCara = true;

        Image imgCara;
        Image imgCoroa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgCara = Image.FromFile(@"imagens\cara_moeda.png");
            imgCoroa = Image.FromFile(@"imagens\coroa_moeda.png");

            pct.Image = imgCara;
            pct.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbCara.Checked)
                escolhaUsuario = 0;
            else
                escolhaUsuario = 1;

            timer1.Interval = 50;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mostrarCara)
                pct.Image = imgCara;
            else
                pct.Image = imgCoroa;

            mostrarCara = !mostrarCara;

            timer1.Interval += 20;

            if (timer1.Interval >= 600)
            {
                timer1.Stop();

                resultado = rnd.Next(0, 2);

                if (resultado == 0)
                    pct.Image = imgCara;
                else
                    pct.Image = imgCoroa;

                if (resultado == escolhaUsuario)
                    MessageBox.Show("Você ganhou!");
                else
                    MessageBox.Show("Você perdeu!");
            }
    }
    }
}
