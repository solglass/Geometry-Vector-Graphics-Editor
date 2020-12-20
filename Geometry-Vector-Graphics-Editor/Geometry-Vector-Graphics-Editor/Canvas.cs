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
        public List<Figure> Figures { get; set; }
        public PointF PrevPoint { get; set; }
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
           Figures= new List<Figure>();
        }

        public void Update(List<PointF> points, int pointsAmount )
        {
            if (CurFigure != null)
            {
                if (CurFigure.PointsAmount == 0)
                {
                    CurFigure.Points = CurFigure.Updater.Update(pointsAmount, points);
                }
                else
                {
                    if (CurFigure.Points == null)
                    {
                        CurFigure.Points = CurFigure.Updater.Update(pointsAmount, points);
                    }
                    else
                    {
                        List<PointF> newList = new List<PointF>();
                        newList.AddRange(CurFigure.Points);
                        newList.Add(points.Last());
                        CurFigure.Points = CurFigure.Updater.Update(CurFigure.PointsAmount, newList);
                    }
                }
            }
        }


        public void Rotate(PointF currentPoint)
        {
            if (CurFigure != null && PrevPoint != null)
            {
                CurFigure.Rotator.Rotate(PrevPoint, currentPoint, CurFigure.Points);

            }
        }

        public void DrawCurrentFigure()
        {
            if (CurFigure != null && _mainBm !=null)
            {
                CloneTmpBitmapFromMain();
                CurFigure.Color = _pen.Color;
                CurFigure.Width =(int) _pen.Width;
                CurFigure.Drawer.Draw(CurFigure.Points, _pen, _graphics);

            }
        }

        public void DrawAll()
        {
            foreach (var figure in Figures)
            {
                _pen.Color = figure.Color;
                _pen.Width = figure.Width;
                figure.Drawer.Draw(figure.Points,_pen,_graphics); }
        }

    }
}
