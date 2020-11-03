using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE
{
    public partial class Form1 : Form
    {
        List<PictureBox> lista = new List<PictureBox>();
        int piezaprincipal = 26, tiempo = 10;
        PictureBox comida = new PictureBox();
        string direccion = "right"; // direccion del snake..xd

        public Form1()
        {
            InitializeComponent();
        }

        public void iniciarJuego()

        {

            tiempo = 10;
            direccion = "right";
            timer1.Interval = 200;
            lblPuntos.Text = "0";
            lista = new List<PictureBox>();

        }
        public void CrearSnake(List<PictureBox> listaPelota, Form formulario, int posicionx, int posiciony)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(posicionx, posiciony);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("bodys");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            listaPelota.Add(pb);
            formulario.Controls.Add(pb);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {



        }
    }
}
