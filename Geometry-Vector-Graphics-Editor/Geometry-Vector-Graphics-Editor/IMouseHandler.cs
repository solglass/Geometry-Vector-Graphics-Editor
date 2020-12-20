using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    interface IMouseHandler
    {     
     public Canvas Canvas { get; set; }
     public object Sender { get; set; }
     public EventArgs E { get; set; }
      void HandleEvent();
    }
}
