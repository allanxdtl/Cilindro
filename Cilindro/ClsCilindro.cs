using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class ClsCilindro: ClsCirculo
    {
        private int altura;

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public ClsCilindro(int altura)
        {
            this.altura = altura;
        }

        public string CalcularSuperficie(double radio)
        {
            double superficie = (2*Math.PI*radio*altura)+(2*Math.PI*radio*radio);
            return superficie.ToString();
        }

        //Comentario de prueba

        public override void DibujarFigura(Graphics g, int x, int y, int diametro)
        {
            CoordX = x;
            CoordY = y;
            for(int i=0; i<altura; i++)
            {
                g.DrawEllipse(pluma, CoordX, CoordY, diametro, diametro/4);
                g.FillEllipse(pincel, CoordX, CoordY, diametro, diametro/4);
                CoordY++;
            }
            
            pincel= new SolidBrush(Color.Red);
            g.FillEllipse(pincel, CoordX, CoordY-altura, diametro, diametro/4);
            pincel = new SolidBrush(Color.White);
            g.FillEllipse(pincel, CoordX, CoordY, diametro, diametro / 4);
        }
    }
}
