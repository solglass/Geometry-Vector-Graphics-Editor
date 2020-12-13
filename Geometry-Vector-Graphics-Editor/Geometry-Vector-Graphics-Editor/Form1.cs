using Geometry_Vector_Graphics_Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics
{
    public partial class Form1 : Form
    {
        Bitmap mainBm;
        Bitmap tmpBm;
        Graphics graphics;
        Pen pen;
        bool md = false;
        Point prevPoint;
        List<IFigure> figures;
        IFigureFactory2points factory2points;
        IFigure2points currentFigure2points;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBm);
            pen = new Pen(Color.Black, 5);
            prevPoint= new Point(0, 0);
            figures = new List<IFigure>();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mainBm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDown1.Value;

        }
         
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            md = true;
            prevPoint = e.Location;
            if (factory2points is SquareFactory)
            {
                prevPoint.Y = prevPoint.X;
                currentFigure2points = factory2points.CreateFigure(prevPoint,
                new PointF(prevPoint.X+75*(float)Math.Sqrt(2), prevPoint.Y+75*(float)Math.Sqrt(2)));
                tmpBm = (Bitmap)mainBm.Clone();
                graphics = Graphics.FromImage(tmpBm);
                graphics.DrawPolygon(pen, currentFigure2points.Points.ToArray());
                pictureBox1.Image = tmpBm;
                GC.Collect();
                md = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (md && factory2points != null)
            {
                tmpBm = (Bitmap)mainBm.Clone();
                graphics = Graphics.FromImage(tmpBm);
                currentFigure2points = factory2points.CreateFigure(prevPoint, new Point(e.X, e.Y));

                //2DO support 
                /*currentFigure.Color = pen.Color;
                currentFigure.Width = (int)pen.Width; 
                */
                currentFigure2points.Update(prevPoint, e.Location);

                //2DO -- move to object
                //currentFigure.Draw(tmpBm, graphics, pen);
                graphics.DrawPolygon(pen, currentFigure2points.Points.ToArray());
                pictureBox1.Image = tmpBm;
                GC.Collect();
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (md && currentFigure2points!=null)
            {
                md = false;
                graphics.DrawPolygon(pen, currentFigure2points.Points.ToArray());
                pictureBox1.Image = tmpBm;
                GC.Collect();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            factory2points = new RectangleFactory(); 

        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            factory2points = new SquareFactory();
        }


        private void buttonDraw_Click(object sender, EventArgs e)
        {

        }


        private void buttonMove_Click(object sender, EventArgs e)
        {

        }
    }
}
