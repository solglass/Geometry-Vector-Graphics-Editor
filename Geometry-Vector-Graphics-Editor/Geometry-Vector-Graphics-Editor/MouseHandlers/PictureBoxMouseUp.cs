using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry_Vector_Graphics_Editor;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseUp : IMouseHandler
    {

        PictureBoxMouseUp(object sender, EventArgs e, Canvas cnvs)
        {
            canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas canvas { get; set; }
        public void HandleEvent(object sender, EventArgs e)
        {
            
        }
    }
}
