using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometry_Vector_Graphics_Editor;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseUpRotate : IMouseHandler
    {

        public PictureBoxMouseUpRotate(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        public void HandleEvent(object sender, EventArgs e)
        {
            MouseEventArgs eMouse = (MouseEventArgs)e;
 
        }
    }
}
