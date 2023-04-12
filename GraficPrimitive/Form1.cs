using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraficPrimitive
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(400, 400);
        public Form1()
        {
            InitializeComponent();
        }
        private void HorizontalLineBtn(object sender, EventArgs e)
        {
            for (int i = 0, j = 300; i < 300; i++, j++)
            {
                if (j == 400)
                    j = 1;
                bitmap.SetPixel(j, 200, Color.Blue);
            }
            pictureBox1.Image = bitmap;
        }
        private void VerticalLineBtn(object sender, EventArgs e)
        {
            for (int i = 0; i < 400; i++)
                bitmap.SetPixel(200, i, Color.Red);
            pictureBox1.Image = bitmap;
        }
        private void RightDiagonalBtn(object sender, EventArgs e)
        {
            for (int i = 0, j = 399; j > 1; i++, j--)
                bitmap.SetPixel(j, i, Color.Yellow);
            pictureBox1.Image = bitmap;
        }
        private void LeftDiagonalBtn(object sender, EventArgs e)
        {
            for (int i = 399; i > 1; i--)
                bitmap.SetPixel(i, i, Color.Brown);
            pictureBox1.Image = bitmap;
        }
        private void ZvNeboBtn(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 400; i++)
                bitmap.SetPixel(r.Next(0,400), r.Next(0,400), 
                    Color.FromArgb(r.Next(0, 254), r.Next(0, 254), r.Next(0, 254)));
            pictureBox1.Image = bitmap;
        }
    }
}