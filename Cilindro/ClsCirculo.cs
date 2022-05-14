using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Cilindro
{
    public class ClsCirculo : IPunto
    {
        //Variables de clase
        protected int x, y;
        protected Pen pluma;
        protected Brush pincel;

        //Constructor de la clase
        public ClsCirculo()
        {
            pluma = new Pen(Color.FromArgb(21,55,205));
            pincel = new SolidBrush(Color.FromArgb(21, 55, 205));
        }

        //Propiedades y metodo implementados de la Interface IPunto
        public int CoordX
        {
            get { return x; }
            set { x = value; }
        }

        public int CoordY
        {
            get { return y; }
            set { y = value; }
        }

        public void CambiarColor(Color c)
        {
            pluma.Color = c;
            pincel = new SolidBrush(c);
        }

        //Metodo para dibujar un circulo en un grafico
        public virtual void DibujarFigura(Graphics g, int x, int y, int diametro)
        {
            g.DrawEllipse(pluma, x, y, diametro, diametro);
            g.FillEllipse(pincel, x, y, diametro, diametro);
        }
    }
}