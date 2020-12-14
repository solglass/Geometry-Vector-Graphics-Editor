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
            //pen.Width = 2;
        }
         
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            md = true;
            prevPoint = e.Location;
            curFigure.Color = pen.Color;
            curFigure.Width = (int)pen.Width;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (md && curFigure!=null)
            {
                switch(mode)
                {
                    case "draw":
                        mainBm = curFigure.Draw((Bitmap)mainBm.Clone(), prevPoint, e.Location);
                        break;
                    case "move":

                        break;
                }
                pictureBox1.Image = mainBm;
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;
            mainBm = tmpBM;
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
            curFigure = new Geometry_Vector_Graphics_Editor.LineFigure();
            mode = "draw";
            
        }
    }
}
