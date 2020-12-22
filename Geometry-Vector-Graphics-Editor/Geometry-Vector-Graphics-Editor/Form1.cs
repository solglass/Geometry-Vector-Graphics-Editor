using Geometry_Vector_Graphics_Editor;
using Geometry_Vector_Graphics_Editor.MouseHandlers;
using Geometry_Vector_Graphics_Editor.Serialization;
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
        private bool clockwise;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _canvas = Canvas.getInstance(pictureBox.Width, pictureBox.Height, Color.Black, 1);
            SerializationFile sf = new SerializationFile();
            sf.LoadFile(_canvas);
            _canvas.Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            _canvas.PictureBoxHeight = pictureBox.Height;
            _canvas.PictureBoxWidth= pictureBox.Width;
            _pictureBoxMouseMove = new PictureBoxMouseMoveDraw();
            if (_canvas.Figures.Count > 0)
            {
                _canvas.DrawAll();
            }
            pictureBox.Image = _canvas.Bitmap;

            _canvas.Clockwise = true;
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
                if (pictureBox.Image != null)
                { _canvas.Bitmap = (Bitmap)pictureBox.Image; }
            }
            else if(_pictureBoxMouseMove is MoveFiguresMouseMove)
            {
                IMouseHandler buttonHandler = new MoveFiguresMouseDown(sender, e, _canvas);
            }
            else if (_pictureBoxMouseMove is PictureBoxMouseMoveRotate)
            {
                IMouseHandler buttonHandler = new PictureBoxMouseDownRotate(sender, e, _canvas);
            }
            else if (_pictureBoxMouseMove is PictureBoxMouseMoveScale)
            {
                IMouseHandler buttonHandler = new PictureBoxMouseDownScale(sender, e, _canvas);
            }

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
                if (_pictureBoxMouseMove is PictureBoxMouseMoveDraw)
                {
                    IMouseHandler buttonHandler = new PictureBoxMouseUpDraw(sender, e, _canvas);
                }
                else if (_pictureBoxMouseMove is MoveFiguresMouseMove)
                {
                    IMouseHandler buttonHandler = new MoveFiguresMouseUp(sender, e, _canvas);
                }
                else if (_pictureBoxMouseMove is PictureBoxMouseMoveRotate)
                { 
                    IMouseHandler buttonHandler = new PictureBoxMouseUpRotate(sender, e, _canvas);
                }
                else if(_pictureBoxMouseMove is PictureBoxMouseMoveScale)
                {
                    IMouseHandler buttonHandler = new PictureBoxMouseUpScale(sender, e, _canvas);
                }
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
            pictureBox.Image = null;
            _canvas.Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            _canvas.CloneTmpBitmapFromMain();

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
            ButtonZigzagClick buttonHandler = new ButtonZigzagClick(sender, e, _canvas, trackBarPointsAmount.Value);

            buttonHandler.PointsAmount = trackBarPointsAmount.Value;
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            _pictureBoxMouseMove = new PictureBoxMouseMoveRotate();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            _pictureBoxMouseMove = new PictureBoxMouseMoveDraw();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializationFile sf = new SerializationFile();
            sf.SaveFile(_canvas);
        }

        private void buttonBrush_Click(object sender, EventArgs e)
        {
            IMouseHandler buttonHandler = new ButtonBrushClick(sender, e, _canvas);
        }

        private void buttonRegularPolygon_Click(object sender, EventArgs e)
        {
            ButtonRegularPolygonClick buttonHandler = new ButtonRegularPolygonClick(sender, e, _canvas, trackBarPointsAmount.Value);
        }

        private void checkBoxClockwise_Click(object sender, EventArgs e)
        {
            clockwise = checkBoxClockwise.Checked;
            _canvas.Clockwise = clockwise;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            _pictureBoxMouseMove = new MoveFiguresMouseMove();
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            _pictureBoxMouseMove = new PictureBoxMouseMoveScale(sender, e,_canvas);
        }
    }
}
