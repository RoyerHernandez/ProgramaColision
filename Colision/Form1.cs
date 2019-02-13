using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colision
{
    public partial class Form1 : Form
    {

        private bool seMueve = false;
        private int ofsetx;
        private int ofsety;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void moverArriba(object sender, MouseEventArgs e)
        {
            seMueve = true;
        }


        private void moverIzq(object sender, MouseEventArgs e)
        {
            seMueve = true;
        }

        private void moverDer(object sender, MouseEventArgs e)
        {
            seMueve = true;
        }

        private void imgMoverMouse(object sender, MouseEventArgs e)
        {
            Control ctr = sender as Control;
            if (seMueve)
            {
                Point P1 = ctr.PointToScreen(e.Location);
                Point P2 = ctr.Parent.PointToClient(P1);
                ctr.Location = P2;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            seMueve = true;
            ofsetx = e.X;
            ofsety = e.Y;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            seMueve = true;
            ofsetx = e.X;
            ofsety = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (seMueve)
            {
                pictureBox1.Left += e.X - ofsetx;
                pictureBox1.Top += e.Y - ofsety;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (seMueve)
            {
                pictureBox2.Left += e.X - ofsetx;
                pictureBox2.Top += e.Y - ofsety;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int locX = 0;
            int locY = 0;

            int loc2X = 0;
            int loc2Y = 0;

            int difX;
            int difY;

            String imagePath = Path.Combine(Application.StartupPath, "E:\\Documentos\\Personal\\Especialización\\Colision\\SquareRed.jpg");            
            String imagePath3 = Path.Combine(Application.StartupPath, "E:\\Documentos\\Personal\\Especialización\\Colision\\CircleRed2.jpg");

            if (e.Button == MouseButtons.Left) {

                seMueve = false;

                locX = pictureBox1.Location.X + pictureBox1.Width;
                locY = pictureBox1.Location.Y + pictureBox1.Height;

                loc2X = pictureBox2.Location.X + pictureBox2.Width;
                loc2Y = pictureBox2.Location.Y + pictureBox2.Height;

                difX = locX - loc2X;
                difY = locY - loc2Y;

                if ( difX >= -100 && difX <= 100 )
                {
                    if (difY >= -100 && difY <= 100) { 
                    button1.Text = "Colision !!";
                    button1.BackColor = Color.Red;
                    pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        button1.Text = "No Hay Colision";
                        button1.BackColor = Color.LightGreen;
                        pictureBox1.Image = Image.FromFile(imagePath3);
                    }
                }
                else
                {
                    button1.Text = "No Hay Colision";
                    button1.BackColor = Color.LightGreen;
                    pictureBox1.Image = Image.FromFile(imagePath3);
                }

            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            int locX = 0;
            int locY = 0;

            int loc2X = 0;
            int loc2Y = 0;

            int difX;
            int difY;

            String imagePath2 = Path.Combine(Application.StartupPath, "E:\\Documentos\\Personal\\Especialización\\Colision\\SquareGreen.jpg");
            String imagePath4 = Path.Combine(Application.StartupPath, "E:\\Documentos\\Personal\\Especialización\\Colision\\CircleGreen.jpg");

            if (e.Button == MouseButtons.Left)
            {
                seMueve = false;

                locX = pictureBox1.Location.X + pictureBox1.Width;
                locY = pictureBox1.Location.Y + pictureBox1.Height;

                loc2X = pictureBox2.Location.X + pictureBox2.Width;
                loc2Y = pictureBox2.Location.Y + pictureBox2.Height;

                difX = locX - loc2X;
                difY = locY - loc2Y;

                if (difX >= -100 && difX <= 100)
                {
                    if (difY >= -100 && difY <= 100)
                    {
                        button1.Text = "Colision !!";
                        button1.BackColor = Color.Red;
                        pictureBox2.Image = Image.FromFile(imagePath2);
                    }
                    else
                    {
                        button1.Text = "No Hay Colision";
                        button1.BackColor = Color.LightGreen;
                        pictureBox2.Image = Image.FromFile(imagePath4);
                    }
                }
                else
                {
                    button1.Text = "No Hay Colision";
                    button1.BackColor = Color.LightGreen;
                    pictureBox2.Image = Image.FromFile(imagePath4);
                }

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
