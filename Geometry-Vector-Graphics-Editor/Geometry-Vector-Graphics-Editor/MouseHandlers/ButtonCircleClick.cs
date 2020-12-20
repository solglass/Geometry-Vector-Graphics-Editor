using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonCircleClick : IMouseHandler
    {
       public ButtonCircleClick(object sender, EventArgs e, Canvas cnvs)
        {   
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        public Canvas Canvas { get; set; }
       
        private CircleFactory circleFactory{get; set;}
        public void HandleEvent()
        {
            circleFactory = new CircleFactory();
            Canvas.CurFigureFactory = circleFactory;
        }
    }
}
