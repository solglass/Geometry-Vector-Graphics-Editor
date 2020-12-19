using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    interface IMouseHandler
    {     
      Canvas Canvas { get; set; }
      void HandleEvent( object sender, EventArgs e);
    }
}
