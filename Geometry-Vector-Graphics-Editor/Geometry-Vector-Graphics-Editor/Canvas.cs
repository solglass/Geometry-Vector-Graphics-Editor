using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Geometry_Vector_Graphics_Editor
{
    class Canvas
    {
        private static Canvas instance;

        Bitmap _mainBm;
        Bitmap _tmpBm;
        Pen _pen;
        Graphics _graphics;
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
                return _pen.Color;
            }
            set
            {
                _pen.Color = value;
            }
        }

        public int PenWidth
        {
            get
            {
                return (int)_pen.Width;
            }
            set
            {
                _pen.Width = (int)value;
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
            _graphics = Graphics.FromImage(_tmpBm);
        }

        public void SetTmpBitmapToMain()
        {
            _mainBm = _tmpBm;
        }



        private Canvas(int width, int height, Color color, int penWidth)
        {
            _mainBm = new Bitmap(width, height);
            _pen = new Pen(color, penWidth);
            _graphics = Graphics.FromImage(_mainBm);
        }
    }
}
