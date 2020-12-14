using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometry_Vector_Graphics_Editor.Figures;

namespace graphics
{
    public partial class Form1 : Form
    {
        Bitmap mainBm;
        Graphics graphics;
        Pen pen;
        bool md = false;
        PointF prevPoint;
        List<IFigure> figures = new List<IFigure>();
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
                graphics = Graphics.FromImage(mainBm);
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;
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
    }
}
