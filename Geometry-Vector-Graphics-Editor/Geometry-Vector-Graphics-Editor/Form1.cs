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
        private Canvas _canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _canvas = Canvas.getInstance(pictureBox.Width, pictureBox.Height, Color.Black, 1);
        }

       

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if(colorDialog1.ShowDialog()!=System.Windows.Forms.DialogResult.Cancel)
            {
                buttonColor.BackColor = colorDialog1.Color;
            }
        }


        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            colorDialog2 = new ColorDialog();
            if (colorDialog2.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                buttonBackColor.BackColor = colorDialog2.Color;
                pictureBox.BackColor = colorDialog2.Color;
            }
        }
    }
}
