using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Geometry_Vector_Graphics_Editor
{
    public class Canvas
    {
        private static Canvas instance;

        Bitmap _mainBm;
        Bitmap _tmpBm;
        private Pen _pen;
        private Graphics _graphics;

        List<Figure> _figures;
        public Figure CurFigure
        {
            get; set;
        }
        public IFigureFactory CurFigureFactory
        {
            get; set;
        }

        public Bitmap Bitmap
        {
            get
            {
                return _tmpBm;
            }
            set
            {
                _mainBm = (Bitmap)value;
            }
        }
        public Color PenColor 
        {
            get
            {
                return Pen.Color;
            }
            set
            {
                Pen.Color = value;
            }
        }

        public int PenWidth
        {
            get
            {
                return (int)Pen.Width;
            }
            set
            {
                Pen.Width = (int)value;
            }
        }
       
        public static Canvas getInstance(int width, int height, Color color, int penWidth)
        {
            if (instance == null)
                instance = new Canvas(width, height, color, penWidth);
            return instance;
        }

        public void CloneTmpBitmapFromMain()
        {
            _tmpBm = (Bitmap)_mainBm.Clone();
            Graphics = Graphics.FromImage(_tmpBm);
        }

        public void SetTmpBitmapToMain()
        {
            _mainBm = _tmpBm;
        }

        private Canvas(int width, int height, Color color, int penWidth)
        {
            _mainBm = new Bitmap(width, height);
            Pen = new Pen(color, penWidth);
            Graphics = Graphics.FromImage(_mainBm);
        }

        public void DrawCurrentFigure()
        {
            if (CurFigure != null )
            {
                CloneTmpBitmapFromMain();
                CurFigure.Drawer.Draw(CurFigure.Points, _pen, _graphics);

            }
        }
    }
}
