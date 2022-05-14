using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cilindro
{
    public interface IPunto
    {
        //Propiedades de la coordenadas del objeto
        int CoordX { get; set; }
        int CoordY { get; set; }
        //Metodo para cambiar el color del objeto
        void CambiarColor(Color c);
    }
}