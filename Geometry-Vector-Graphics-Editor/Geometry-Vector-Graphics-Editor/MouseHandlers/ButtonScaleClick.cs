using Geometry_Vector_Graphics_Editor.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonScaleClick : IMouseHandler
    {
        ButtonScaleClick(object sender, EventArgs e, Canvas cnvs)
        {
            canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas canvas { get; set; }
        private IScaler currentScaler;
        public void HandleEvent(object sender, EventArgs e)
        {

        }
    }
}
