using Geometry_Vector_Graphics_Editor;
using Geometry_Vector_Graphics_Editor.MouseHandlers;
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
        private IMouseHandler _pictureBoxMouseMove;
        private bool md;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _canvas = Canvas.getInstance(pictureBox.Width, pictureBox.Height, Color.Black, 1);
            _canvas.Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            _pictureBoxMouseMove = new PictureBoxMouseMoveDraw();
        }

       

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if(colorDialog1.ShowDialog()!=System.Windows.Forms.DialogResult.Cancel)
            {
                buttonColor.BackColor = colorDialog1.Color;
                _canvas.PenColor = colorDialog1.Color;
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

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            IMouseHandler buttonHandler = new ButtonRectangleClick(sender, e, _canvas);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            md = true;
            if (_pictureBoxMouseMove is PictureBoxMouseMoveDraw)
            {
                IMouseHandler buttonHandler = new PictureBoxMouseDownDraw(sender, e, _canvas);
            }
            else if (_pictureBoxMouseMove is PictureBoxMouseMoveRotate)
            { IMouseHandler buttonHandler = new PictureBoxMouseDownRotate(sender, e, _canvas); }
            if (pictureBox.Image != null)
            { _canvas.Bitmap = (Bitmap)pictureBox.Image; }
            GC.Collect();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (md)
            {
                _pictureBoxMouseMove.E = e;
                _pictureBoxMouseMove.Sender = sender;
                _pictureBoxMouseMove.Canvas = _canvas;
                _pictureBoxMouseMove.HandleEvent();
                pictureBox.Image = _canvas.Bitmap;
                GC.Collect();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (md)
            {
                PictureBoxMouseUpDraw pictureBoxMouseUpHandler = new PictureBoxMouseUpDraw(sender, e, _canvas);
                pictureBox.Image = _canvas.Bitmap;
                GC.Collect();
            }
            md = false;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            ButtonEllipseClick ellipseClick = new ButtonEllipseClick(sender, e, _canvas);
        }

        private void buttonCircle_Click_1(object sender, EventArgs e)
        {
            ButtonCircleClick circleClick = new ButtonCircleClick(sender, e, _canvas);
        }

        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            _canvas.PenWidth = trackBarWidth.Value;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            ButtonLineClick lineClick = new ButtonLineClick(sender, e, _canvas);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _canvas.Figures = new List<Figure>();
            _canvas.Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = null;
        }

        private void buttonRectangularTriangle_Click(object sender, EventArgs e)
        {
            IMouseHandler buttonHandler = new ButtonRectangularTriangleClick(sender, e, _canvas);
        }

        private void buttonIsoscalesTriangle_Click(object sender, EventArgs e)
        {
            IMouseHandler buttonHandler = new ButtonIsoscelesTriangleClick (sender, e, _canvas);
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            IMouseHandler buttonHandler = new ButtonSquareClick(sender, e, _canvas);
        }

        private void buttonZigzag_Click(object sender, EventArgs e)
        {
            IMouseHandler buttonHandler = new ButtonZigzagClick(sender, e, _canvas);
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            _pictureBoxMouseMove = new PictureBoxMouseMoveDraw();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            _pictureBoxMouseMove = new PictureBoxMouseMoveDraw();
        }
    }
}
