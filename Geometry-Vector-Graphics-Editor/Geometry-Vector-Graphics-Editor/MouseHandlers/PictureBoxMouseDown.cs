using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseDown: IMouseHandler
    {
       public PictureBoxMouseDown(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private IFigureFactory curFigureFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            if (Canvas.CurFigureFactory != null)
            {
                Canvas.CurFigure = Canvas.CurFigureFactory.CreateFigure();
            }
        }
    }
}
