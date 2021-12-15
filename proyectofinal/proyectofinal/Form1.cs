using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class Form1 : Form
    {
        int[,] vectoragua = { { 10, 30, 50 }, { 20, 50, 60 }, { 10, 40, 70 }, { 10, 45, 55 }, { 10, 39, 55 }, { 9, 55, 70 }, { 20, 70, 80 }, { 9, 34, 50 }, { 9, 50, 50 }, { 35, 52, 90 }, { 35, 60, 75 }, { 30, 50, 71 }, { 16, 41, 98 } };
        int[,] vectortierra = { { 115, 110, 95 }, { 140, 130, 115 }, { 165, 150, 135 }, { 168, 157, 138 }, { 192, 174, 147 }, { 165, 170, 165 }, { 148, 128, 105 }, { 133, 130, 125 }, { 110, 110, 110 }, { 185, 175, 165 }, { 197, 175, 160 }, { 210, 195, 175 }, { 155, 135, 112 }, { 85, 85, 75 }, { 95, 90, 81 }, { 179, 147, 129 }, { 75, 96, 66 }, { 160, 145, 120 }, { 182, 175, 65 } };
        int[,] vectorbosque = { { 35, 60, 50 }, { 15, 30, 30 }, { 34, 34, 40 }, { 40, 70, 58 }, { 30, 45, 40 }, { 9, 35, 35 }, { 85, 75, 58 }, { 50, 75, 65 }, { 35, 60, 35 }, { 30, 60, 35 }, { 36, 73, 41 }, { 58, 94, 58 } };
        int[,] vectornieve = { { 170, 174, 175 }, { 175, 179, 80 }, { 182, 186, 187 }, { 187, 193, 196 }, { 212, 217, 219 }, { 217, 222, 223 }, { 227, 230, 232 }, { 234, 237, 238 }, { 233, 238, 240 }, { 239, 242, 243 }, { 241, 244, 245 }, { 250, 251, 252 } };

        int cR, cG, cB;

        int cmR, cmG, cmB;
        Bitmap Imagen;

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            Color d = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int x = i; x < i + 5; x++)
                        for (int y = j; y < j + 5; y++)
                        {
                            c = bmp.GetPixel(x, y);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                        }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;
                    int valor = 0;
                    for (int z = 0; z < vectortierra.GetLength(0); z++)
                        if (((vectortierra[z, 0] - 10 < ciR) && (ciR < vectortierra[z, 0] + 10)) && ((vectortierra[z, 1] - 10 < ciG) && (ciG < vectortierra[z, 1] + 10)) && ((vectortierra[z, 2] - 10 < ciB) && (ciB < vectortierra[z, 2] + 10)))
                        {
                            valor = 1;
                        }

                    switch (valor)
                    {
                        case 1:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, Color.FromArgb(52, 20, 10));
                                }
                            break;

                        default:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    d = bmp.GetPixel(x, y);
                                    bmp2.SetPixel(x, y, Color.FromArgb(d.R, d.G, d.B));
                                }
                            break;
                    }
                }
            pictureBox1.Image = bmp2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            Color d = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int x = i; x < i + 5; x++)
                        for (int y = j; y < j + 5; y++)
                        {
                            c = bmp.GetPixel(x, y);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                        }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;
                    int valor = 0;
                    for (int z = 0; z < vectorbosque.GetLength(0); z++)
                        if (((vectorbosque[z, 0] - 10 < ciR) && (ciR < vectorbosque[z, 0] + 10)) && ((vectorbosque[z, 1] - 10 < ciG) && (ciG < vectorbosque[z, 1] + 10)) && ((vectorbosque[z, 2] - 10 < ciB) && (ciB < vectorbosque[z, 2] + 10)))
                        {
                            valor = 1;
                          
                        }
                    switch (valor)
                    {
                        case 1:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, Color.FromArgb(22, 109, 21));
                                }
                            break;

                        default:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    d = bmp.GetPixel(x, y);
                                    bmp2.SetPixel(x, y, Color.FromArgb(d.R, d.G, d.B));
                                }
                            break;
                    }
                }
            pictureBox1.Image = bmp2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            Color d = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int x = i; x < i + 5; x++)
                        for (int y = j; y < j + 5; y++)
                        {
                            c = bmp.GetPixel(x, y);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                        }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;
                    int valor = 0;
                    for (int z = 0; z < vectornieve.GetLength(0); z++)
                        if (((vectornieve[z, 0] - 10 < ciR) && (ciR < vectornieve[z, 0] + 10)) && ((vectornieve[z, 1] - 10 < ciG) && (ciG < vectornieve[z, 1] + 10)) && ((vectornieve[z, 2] - 10 < ciB) && (ciB < vectornieve[z, 2] + 10)))
                        {
                            valor = 1;
                        
                        }

                    switch (valor)
                    {
                        case 1:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, Color.FromArgb(201, 204, 205));
                                }
                            break;

                        default:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    d = bmp.GetPixel(x, y);
                                    bmp2.SetPixel(x, y, Color.FromArgb(d.R, d.G, d.B));
                                }
                            break;
                    }
                }
            pictureBox1.Image = bmp2;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
          
                pictureBox1.Image = Imagen;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
              Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            Color d = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < bmp.Width - 5; i = i + 5)
                for (int j = 0; j < bmp.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int x = i; x < i + 5; x++)
                        for (int y = j; y < j + 5; y++)
                        {
                            c = bmp.GetPixel(x, y);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                        }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;
                    int valor = 0;
                    for (int z = 0; z < vectoragua.GetLength(0); z++)
                        if (((vectoragua[z, 0] - 10 < ciR) && (ciR < vectoragua[z, 0] + 10)) && ((vectoragua[z, 1] - 10 < ciG) && (ciG < vectoragua[z, 1] + 10)) && ((vectoragua[z, 2] - 10 < ciB) && (ciB < vectoragua[z, 2] + 10)))
                        {
                            valor = 1;
                            
                        }
                    switch (valor)
                    {
                        case 1:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    bmp2.SetPixel(x, y, Color.FromArgb(18, 42, 84));
                                }
                            break;

                        default:
                            for (int x = i; x < i + 5; x++)
                                for (int y = j; y < j + 5; y++)
                                {
                                    d = bmp.GetPixel(x, y);
                                    bmp2.SetPixel(x, y, Color.FromArgb(d.R, d.G, d.B));
                                }
                            break;
                    }

                }
            pictureBox1.Image = bmp2;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes JPG|*.jpg";
            ofd.ShowDialog();
            Imagen = new Bitmap(ofd.FileName);
            pictureBox1.Image = Imagen;
        }

      

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
