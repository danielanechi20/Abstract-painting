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
    abstract public class Figura
    {
        protected Image img;
        protected int x, y,x2,y2, x3,y3,x4,y4; //coordonate pentru figuri
        public abstract void deseneaza(Graphics g);
        public abstract double daLungime();
    }
     public class Linie :Figura
    { 
        public Linie(Image img, int x, int y, int x2,int y2)
        {
            this.img = img;
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void deseneaza(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, x,y,x2,y2);
        }
        public override double daLungime()
        {
            return Math.Sqrt((Math.Pow((x2-x),2)+ Math.Pow((y2 -y), 2)));
        }
    }
    public class Triunghi : Figura
    {
        public Triunghi (Image img,int x, int y) 
        {
            this.img = img;
            this.x = x;
            this.y = y;
        }
        public override void deseneaza(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Random rs = new Random();
            Rectangle r = new Rectangle(x, y, img.Width, img.Height);
            Point[] P ={new Point(r.X+rs.Next(0,img.Width-r.X),r.Y+rs.Next(0,img.Height-r.Y)),
            new Point(r.X+rs.Next(0,img.Width-r.X),r.Y+rs.Next(0,img.Height-r.Y)),
            new Point(r.X + rs.Next(0,img.Width-r.X), r.Y+rs.Next(0,img.Height-r.Y)) };
             g.DrawPolygon(pen, P);
        }
        public override double daLungime()
        {
            Random rs = new Random();
            Rectangle r = new Rectangle(x, y, img.Width, img.Height);
            Point P1 = new Point(r.X + rs.Next(0, img.Width - r.X), r.Y + rs.Next(0, img.Height - r.Y));
            int x1 = r.X + rs.Next(0, img.Width - r.X);
            int y1= r.Y + rs.Next(0, img.Height - r.Y);
            Point P2 = new Point(r.X + rs.Next(0, img.Width - r.X), r.Y + rs.Next(0, img.Height - r.Y));
            int x2= r.X + rs.Next(0, img.Width - r.X);
            int y2= r.Y + rs.Next(0, img.Height - r.Y);
            Point P3 = new Point(r.X + rs.Next(0, img.Width - r.X), r.Y + rs.Next(0, img.Height - r.Y));
            int x3= r.X + rs.Next(0, img.Width - r.X);
            int y3= r.Y + rs.Next(0, img.Height - r.Y);
            Point[] P ={P1,P2,P3 };
            
            return (Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2))+
                Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2))+
                Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2))) ;
        }
    }
    public class Dreptunghi : Figura
    {
        public Dreptunghi(Image img, int x, int y)
        {
            this.img = img;
            this.x = x;
            this.y = y;
        }
        public override void deseneaza(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Random rs = new Random();
                Rectangle r = new Rectangle(x , y , rs.Next(0,img.Width),rs.Next(0,img.Height));
                g.DrawRectangle(pen, r);
            
        }
        public override double daLungime()
        {
            Random rs = new Random();
            Rectangle r = new Rectangle(x, y, rs.Next(0, img.Width), rs.Next(0, img.Height));
            return 2* (rs.Next(0, img.Width)-x)+2*(rs.Next(0, img.Height)-y);
        }
    }
    public class Elipsa : Figura
    {
        public Elipsa(Image img, int x, int y)
        {
            this.img = img;
            this.x = x;
            this.y = y;
        }
        public override void deseneaza(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Random rs = new Random();
            Rectangle r = new Rectangle(x, y, rs.Next(0,img.Width-x) , rs.Next(0,img.Height - y));
            g.DrawEllipse(pen, r);
        }
        public override double daLungime()
        {
            Random rs = new Random();
            Rectangle r = new Rectangle(x, y, rs.Next(0, img.Width - x), rs.Next(0, img.Height - y));
            return (2*Math.PI*Math.Sqrt((Math.Pow(rs.Next(0, img.Width - x)/2,2)+ Math.Pow(rs.Next(0, img.Height - y)/2,2))/2));
        }
    }
    public class Curba : Figura
    {
        public Curba(Image img, int x, int y, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.img = img;
            this.x = x; 
            this.y = y; 
            this.x2 = x2; 
            this.y2= y2;
            this.x3= x3;
            this.y3= y3;
            this.x4= x4;
            this.y4= y4;
        }
        public override void deseneaza(Graphics g)
        {
            
            Pen pen = new Pen(Color.Black, 2);
            g.DrawBezier(pen, x,y,x2,y2,x3,y3,x4,y4 );
            
            
        }
        double _bezier_point(double t, double start, double control_1,
                 double control_2, double end)
        {
            /* Formula from Wikipedia article on Bezier curves. */
            return start * (1.0 - t) * (1.0 - t) * (1.0 - t)
                   + 3.0 * control_1 * (1.0 - t) * (1.0 - t) * t
               + 3.0 * control_2 * (1.0 - t) * t * t
                 + end * t * t * t;
        }
        public override double daLungime()
        {
                double t;
                int i;
                int steps;
                double []X=new double[10];
                double []Y=new double [10];
                double length = 0.0;
                steps = 10;
                for (i = 0; i <= steps; i++)
                {
                    t = (double)i / (double)steps;
                    X[i] = _bezier_point(t, x, x2, x3, x4);
                    Y[i] = _bezier_point(t, y, y2, y3, y4);
                    if (i > 0)
                    {
                        double x_diff = X[i] - X[i-1];
                        double y_diff = Y[i] - Y[i - 1];
                        length += Math.Sqrt(x_diff * x_diff + y_diff * y_diff);
                    }
                   
                }
                return length;
        }
    }
}
