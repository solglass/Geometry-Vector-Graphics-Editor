using Geometry_Vector_Graphics_Editor.Actors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Updaters
{
    class ZigzagUpdater : IUpdater
    {
        public List<PointF> Update(int pointsAmount, List<PointF> points)
        {
            if (points.Count() > 2)
            {
                points.RemoveAt(points.Count - 2);
            }
            //if(pointsAmount<points.Count())
            //{
            //    for(int i= points.Count-pointsAmount; i>0;)
            //    {
            //        points.RemoveAt(points.Count - 1);
            //    }
            //}
            return points;
        }
    }
}
