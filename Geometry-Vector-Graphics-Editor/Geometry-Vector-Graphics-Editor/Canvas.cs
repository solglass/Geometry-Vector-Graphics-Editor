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

        Bitmap mainBm;
        Bitmap tmpBm;
        Pen pen;
        Graphics graphics;

        public Bitmap Bitmap
        {
            get
            {
                return mainBm;
            }
            private set
            {

            }
        }
        private Canvas(int width, int height)
        {
            mainBm = new Bitmap(width, height);
            pen = new Pen(Color.Black, 1);
            graphics = Graphics.FromImage(mainBm);
        }


        public static Canvas getInstance(int width, int height)
        {
            if (instance == null)
                instance = new Canvas(width, height);
            return instance;
        }
    }
}
