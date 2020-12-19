using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
    public abstract class AbstractFigure
    {
        public List<PointF> Points { get; set; }
        public Color Color { get; protected set; }
        public int Width { get; protected set; }
   
        public bool IsCorrect()
        {
            if(Points!=null && Points.Count()>0 && Color!=null && Width!=0)
            {
                return true;
            }
            return false;
        }

        public bool IsSelected(PointF point, int accuracy)
        {
            PointF prevP = Points[0];
            foreach (PointF p in Points)
            {
                if (CoordinateRoutines.Contains(prevP, p, point, accuracy))
                {
                    return true;
                }
                prevP = p;
            }
            return false;
        }

        public bool Contains(PointF startPoint, PointF endPoint, PointF point, int accuracy)
        {
            return (CoordinateRoutines.Contains(startPoint, endPoint, point, accuracy));
        }
        
       //2DO method for checking if point is selected (the corner)
    }
}
