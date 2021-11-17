using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISOR2_TABCONTROL
{
    public partial class Form1 : Form
    {
        String img;
        int i = 0;
        string[] numero = { "1", "2", "3", "4", "5", "6", "7", "8" };

        //Variable Local
        int Zoom = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            img = "F1-" + numero[i] + ".jpg";
            pictureBox1.Image = Image.FromFile(@"D:\MECATRONICA\4CUARTO CUATRI\PROGRAMACION\F1\" + img);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                img = "F1-" + numero[i] + ".jpg";
            }
            pictureBox1.Image = Image.FromFile(@"D:\MECATRONICA\4CUARTO CUATRI\PROGRAMACION\F1\" + img);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (i < 7)
            {
                i++;
                img = "F1-" + numero[i] + ".jpg";
            }
            pictureBox1.Image = Image.FromFile(@"D:\MECATRONICA\4CUARTO CUATRI\PROGRAMACION\F1\" + img);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"D:\MECATRONICA\4CUARTO CUATRI\PROGRAMACION\F1\" + img);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox2.Width = pictureBox2.Image.Width;
            pictureBox2.Height = pictureBox2.Image.Height;
        }

        private void buttonmas_Click(object sender, EventArgs e)
        {
            Zoom++;
            pictureBox2.Height += Zoom;
            pictureBox2.Width += Zoom;
        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            Zoom--;
            pictureBox2.Height -= Zoom;
            pictureBox2.Width -= Zoom;
        }
    }
}
