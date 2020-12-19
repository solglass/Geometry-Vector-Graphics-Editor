using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonEllipseClick : IMouseHandler
    {
        ButtonEllipseClick(object sender, EventArgs e, Canvas cnvs)
        {   
            canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas canvas { get; set; }
        private EllipseFactory ellipseFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            ellipseFactory = new EllipseFactory();
        }
    }
}
