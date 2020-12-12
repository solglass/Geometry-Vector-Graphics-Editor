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
        IFigure2points currentFigure;

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
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (md)
            {
                tmpBm = (Bitmap)mainBm.Clone();
                graphics = Graphics.FromImage(tmpBm);
                currentFigure = factory2points.CreateFigure(prevPoint,new Point(e.X,e.Y));
               //2DO support 
                /*currentFigure.Color = pen.Color;
                currentFigure.Width = (int)pen.Width; 
                */
                currentFigure.Update(prevPoint, e.Location);
              
                //2DO -- move to object
                //currentFigure.Draw(tmpBm, graphics, pen);
                graphics.DrawPolygon(pen, currentFigure.Points.ToArray());
                pictureBox1.Image = tmpBm;
                GC.Collect();
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;
            graphics.DrawPolygon(pen, currentFigure.Points.ToArray());
            pictureBox1.Image = tmpBm;
            GC.Collect();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            factory2points = new RectangleFactory(); 

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            factory2points = new SquareFactory();
        }
    }
}
