using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Serialization
{
    public class SerializationFile
    {
        public void SaveFile(Canvas canvas)
        {
            BinaryFormatter formatter = new BinaryFormatter();
           try
            {
                FileStream fileStreamFigures = new FileStream("Figures.dat", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fileStreamFigures, canvas.Figures);
                fileStreamFigures.Close();
            }
            catch { }
            
        }

        public void LoadFile(Canvas canvas)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                FileStream fileStream = new FileStream("Figures.dat", FileMode.Open, FileAccess.Read);
                canvas.Figures = (List<Figure>)formatter.Deserialize(fileStream);
                fileStream.Close();
            }
            catch { }

        }
    }

}
