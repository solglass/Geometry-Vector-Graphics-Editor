using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonStubClick : IMouseHandler
    {
        ButtonStubClick(object sender, EventArgs e, Canvas cnvs)
        {   
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private IFigureFactory stubFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            
        }
    }
}
