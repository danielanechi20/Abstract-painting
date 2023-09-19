using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace proiect1
{
    public partial class tablou : Form
    {
        public tablou()
        {
            InitializeComponent();
        }
        Image img;
        Image imgc;
        Graphics g;
        Graphics gc;
        List<Figura> figuri;

        private void tablou_Load(object sender, EventArgs e)
        {
            img = new Bitmap(p.Width, p.Height);
            imgc = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);
            gc = Graphics.FromImage(imgc);
            figuri = new List<Figura>();
        }
        private void exit_Click(object sender, EventArgs e) //iesirea din aplicatie
        {
            this.Close();
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            sfd.FilterIndex = 2;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Image imgSave = new Bitmap(img.Width, img.Height);
                Graphics gSave = Graphics.FromImage(imgSave);
                gSave.DrawImage(img, 0, 0);
                imgSave.Save(sfd.FileName);
            }
            else sfd.Dispose();

        }
        void alegefiguri()
        {
           // figuri.Clear();
            Random rs = new Random();
            if (triunghiuri.CheckOnClick == true)
            {
                for (int i = 0; i < Convert.ToInt32((text.Text)); i++)
                {
                    figuri.Add(new Triunghi(img, rs.Next(0, img.Width), rs.Next(0, img.Height)));
                }
                triunghiuri.CheckOnClick = false;
            }
            if (dreptunghi.CheckOnClick == true)
            {
                for (int i = 0; i < Convert.ToInt32((text.Text)); i++)
                {
                    figuri.Add(new Dreptunghi(img, rs.Next(0, img.Width), rs.Next(0, img.Height)));
                }
                dreptunghi.CheckOnClick = false;
            }
            if (elipse.CheckOnClick == true)
            {
                for (int i = 0; i < Convert.ToInt32((text.Text)); i++)
                {
                    figuri.Add(new Elipsa(img, rs.Next(0, img.Width), rs.Next(0, img.Height)));
                }
                elipse.CheckOnClick = false;
            }
            if (linii.CheckOnClick == true)
            {
                List<Figura> lines;
                lines = new List<Figura>();
                for (int i = 0; i < Convert.ToInt32((text.Text)); i++)
                {
                    if (lines.Count == 0)
                    {
                        lines.Add(new Linie(img, 0, rs.Next(img.Height), rs.Next(img.Width), 0));
                        lines.Add(new Linie(img, rs.Next(img.Width), 0, img.Width, rs.Next(img.Height)));
                        lines.Add(new Linie(img, img.Width, rs.Next(img.Height), rs.Next(img.Width), img.Height));
                        lines.Add(new Linie(img, rs.Next(img.Width), img.Height, 0, rs.Next(img.Height)));
                        lines.Add(new Linie(img, 0, rs.Next(img.Height), img.Width, rs.Next(img.Height)));
                        lines.Add(new Linie(img, rs.Next(img.Width), 0, rs.Next(img.Width), img.Height));
                    }
                    figuri.Add(lines.Last());
                    lines.Remove(lines.Last());
                }

                linii.CheckOnClick = false;
            }
            if (curbe.CheckOnClick == true)
            {
                List<Figura> curves;
                curves = new List<Figura>();
                for (int i = 0; i < Convert.ToInt32((text.Text)); i++)
                {
                    if (curves.Count == 0)
                    {
                        curves.Add(new Curba(img, 0, rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), 0));
                        curves.Add(new Curba(img, rs.Next(img.Width), 0, rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), img.Width, rs.Next(img.Height)));
                        curves.Add(new Curba(img, img.Width, rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), img.Height));
                        curves.Add(new Curba(img, rs.Next(img.Width), img.Height, rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), 0, rs.Next(img.Height)));
                        curves.Add(new Curba(img, 0, rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), img.Width, rs.Next(img.Height)));
                        curves.Add(new Curba(img, rs.Next(img.Width), 0, rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), rs.Next(img.Height), rs.Next(img.Width), img.Height));
                    }
                    figuri.Add(curves.Last());
                    curves.Remove(curves.Last());
                }

                curbe.CheckOnClick = false;
            }

        }
        void deseneazafiguri(Graphics g)
        {
            g.Clear(Color.White);
            foreach (Figura f in figuri)
            {
                f.deseneaza(g);
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            alegefiguri();
            deseneazafiguri(g);
            p.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }
        private void linii_Click(object sender, EventArgs e)
        {
            linii.CheckOnClick = true;
        }
        private void triunghiuri_Click(object sender, EventArgs e)
        {
            triunghiuri.CheckOnClick = true;
        }
        private void dreptunghi_Click(object sender, EventArgs e)
        {
            dreptunghi.CheckOnClick = true;
        }
        private void elipse_Click(object sender, EventArgs e)
        {
            elipse.CheckOnClick = true;
        }
        private void curbe_Click(object sender, EventArgs e)
        {
            curbe.CheckOnClick = true;
        }
        private void fill_Click(object sender, EventArgs e)
        {
            p.Cursor = new Cursor("cur.ico");
        }

        private void paint_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            paint.BackColor = cd.Color;
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                print.Print();
            }
        }
        private void print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }
        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tablou realizat astazi: " + DateTime.Now.ToString() + ". \n Acum esti un artist.", "Felicitari!");
        }
        static void Fill4(Image img, Point pt, Color c0, Color c1)
        {
            if (pt.X < 0 || pt.X > img.Width) return;
            if (pt.Y < 0 || pt.Y > img.Height) return;
            Color cx = ((Bitmap)img).GetPixel(pt.X, pt.Y);
            if (cx.GetBrightness() < 0.01f) return;
            Rectangle imgRect = new Rectangle(Point.Empty, img.Size);
            Stack<Point> stack = new Stack<Point>();
            int x0 = pt.X;
            int y0 = pt.Y;

            stack.Push(new Point(x0, y0));
            while (stack.Any())
            {
                Point p = stack.Pop();
                if (!imgRect.Contains(p)) continue;
                cx = ((Bitmap)img).GetPixel(p.X, p.Y);
                if (cx.ToArgb() == c0.ToArgb())  //*
                {
                    ((Bitmap)img).SetPixel(p.X, p.Y, c1);
                    stack.Push(new Point(p.X, p.Y + 1));
                    stack.Push(new Point(p.X, p.Y - 1));
                    stack.Push(new Point(p.X + 1, p.Y));
                    stack.Push(new Point(p.X - 1, p.Y));
                }
            }
        }
        private void p_MouseClick(object sender, MouseEventArgs e)
        {
            Image image = img;
            Fill4(image, e.Location, ((Bitmap)image).GetPixel(e.X, e.Y), cd.Color);
            p.Image = image;

        }
        private void inks_Click(object sender, EventArgs e)
        {

            ink f2 = new ink();
            f2.ShowDialog();
        }

        private void p_Click(object sender, EventArgs e)
        {
        }
    }
}
