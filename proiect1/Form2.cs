using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect1
{
    public partial class ink : Form
    {
        public ink()
        {
            InitializeComponent();
        }
        void conversie(double R, double G, double B, out double C, out double Y, out double M, out double K)
        {
            double R1;
            double G1;
            double B1;
            R1 = R / 255.0;
            G1 = G / 255.0;
            B1 = B / 255.0;
            double max = Math.Max(Math.Max(R1, G1), B1);
            K = 1 - max;
            if (K == 1)
            {
                C = 0;
                Y = 0;
                M = 0;
            }
            else
            {
                C = (1 - R1 - K) / (1 - K);
                M = (1 - G1 - K) / (1 - K);
                Y = (1 - B1 - K) / (1 - K);
            }
        }
        void daCuloare(Image img, out double R, out double G, out double B )
        {
            int r = 0;
            int g= 0;
            int b= 0;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = ((Bitmap)img).GetPixel(i, j);
                    r += pixel.R;
                    g+=pixel.G;
                    b+=pixel.B;
                }
            }
            R = r;
            G = g;
            B = b;
        }
        private PictureBox _thePicture;
        public PictureBox ThePicture
        {
            set { this._thePicture = value; }
            get { return this._thePicture; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ////Image img = p.Image;
            ////double R, G, B, C, Y, M, K;
            ////daCuloare(img, out R, out G, out B);
            ////conversie(R, G, B, out C, out Y, out M, out K);
            ////double ct = (img.Width * img.Height) / Convert.ToInt32((ml.Text));
            ////Cyan.Text = Convert.ToString((ct * C) / (C + M + Y + K));
            ////Magenta.Text = Convert.ToString((ct * M) / (C + M + Y + K));
            ////Yellow.Text = Convert.ToString((ct * Y) / (C + M + Y + K));
            ////Black.Text = Convert.ToString((ct * K) / (C + M + Y + K));
        }
    }
}
