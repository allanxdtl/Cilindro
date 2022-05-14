using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cilindro
{
    public interface IPunto
    {
        int CoordX { get; set; }
        int CoordY { get; set; }
        void CambiarColor(Color c);

    }
}