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
        
        
        public Bitmap Bitmap
        {
            get
            {
                return _mainBm;
            }
            private set
            {

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
        private Canvas(int width, int height)
        {
            _mainBm = new Bitmap(width, height);
            _pen = new Pen(Color.Black, 1);
            _graphics = Graphics.FromImage(_mainBm);
        }


        public static Canvas getInstance(int width, int height)
        {
            if (instance == null)
                instance = new Canvas(width, height);
            return instance;
        }
    }
}
