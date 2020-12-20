using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Geometry_Vector_Graphics_Editor.Actors
{
    public interface IScaler
    {
        void Scale(float dx, float dy, List<PointF> points);

    }
}
