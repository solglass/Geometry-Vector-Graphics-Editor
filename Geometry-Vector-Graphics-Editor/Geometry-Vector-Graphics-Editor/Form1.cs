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
        Bitmap tmpBM;
        
        Graphics graphics;
        Pen pen;
        bool md = false;
        PointF prevPoint;
        string mode = "";
        string figure = "";
        List<Geometry_Vector_Graphics_Editor.IFigure> figures;
        Geometry_Vector_Graphics_Editor.IFigure curFigure;
        //List<IFigure> figures = new List<IFigure>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBm);
            pen = new Pen(Color.Black, (int)numericUpDown1.Value);
            prevPoint = new PointF(0, 0);
            figures = new List<Geometry_Vector_Graphics_Editor.IFigure>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mainBm;
            curFigure = null;
        }

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDown1.Value;
           
        }
         
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(mode.Equals("draw"))
            {
            curFigure = new Geometry_Vector_Graphics_Editor.LineFigure();
            
            curFigure.Color = pen.Color;
            curFigure.Width = (int)pen.Width;
            }
            else if(mode.Equals("move"))
            {
                curFigure = null;
               // foreach(Geometry_Vector_Graphics_Editor.IFigure figure in figures)
                for (int i=0; i<figures.Count();i++)
                {
                    if (figures[i].IsChosen(e.Location))
                    {
                        pen.Color = figures[i].Color;
                        pen.Width = figures[i].Width;
                        curFigure = figures[i];
                        figures.Remove(curFigure);
                        DrawAll();
                    }
                }
            }
            md = true;
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (md && curFigure!=null)
            {
                tmpBM = (Bitmap)mainBm.Clone();
                graphics = Graphics.FromImage(tmpBM);

                switch (mode)
                {
                    case "draw":
                        curFigure.UpdatePoints(prevPoint, e.Location);
                       
                       //tmpBM= curFigure.Draw(tmpBM);
                        break;
                    case "move":
                        PointF delta = new PointF(e.X - prevPoint.X, e.Y - prevPoint.Y);
                        curFigure.Move(delta);
                        prevPoint = e.Location;
                        break;
                }
                graphics.DrawLine(pen, curFigure.Points.First(), curFigure.Points.Last());
                pictureBox1.Image = tmpBM;
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;
            mainBm = tmpBM;
            if(curFigure!=null && curFigure.IsCompleted())
            {
                figures.Add(curFigure);
            }
        }

 
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()!=System.Windows.Forms.DialogResult.Cancel)
            {
                textBox2.Text = "";
                textBox2.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figure = "line";
            //curFigure = new Geometry_Vector_Graphics_Editor.LineFigure();
            
            mode = "draw";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mode = "move";
        }

        private void DrawAll()
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBm);

            foreach (Geometry_Vector_Graphics_Editor.IFigure figure in figures)
            {
                pen.Color = figure.Color;
                pen.Width = figure.Width;
                graphics.DrawLine(pen, figure.Points[0], figure.Points[1]);
            }

        }
    }
}
