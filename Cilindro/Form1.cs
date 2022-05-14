using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cilindro
{
    public partial class Form1 : Form
    {
        //Declaracion de objetos
        readonly ClsCirculo circulo;
        readonly ClsCilindro cilindro;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            //Aqui se instancias las clases
            circulo = new ClsCirculo();
            cilindro = new ClsCilindro(1);
            panel1.BackColor = Color.FromArgb(79, 218, 232);
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //xd
            //Se crea un grafico para dibujar en panel1
            g = panel1.CreateGraphics();
            g.Clear(Color.FromArgb(79, 218, 232));
            switch (comboBox1.SelectedIndex)
            {
                //Circulo
                case 0:
                    circulo.CoordX = Convert.ToInt16(txtCoordX.Text);
                    circulo.CoordY = Convert.ToInt16(txtCoordY.Text);
                    circulo.DibujarFigura(g, circulo.CoordX, circulo.CoordY, Convert.ToInt16(txtRadio.Text)*2);
                    break;
                //Cilindro
                case 1:
                    //Se obtienen los datos del usuario
                    cilindro.Altura = Convert.ToInt32(txtAltura.Text);
                    cilindro.CoordX = Convert.ToInt16(txtCoordX.Text);
                    cilindro.CoordY = Convert.ToInt16(txtCoordY.Text);
                    //Se dibuja en la forma
                    cilindro.DibujarFigura(g, cilindro.CoordX, cilindro.CoordY, Convert.ToInt16(txtRadio.Text)*2);
                    //Escribe la superficie en el label de la forma
                    lblSuperficie.Text = $"Superficie {cilindro.CalcularSuperficie(Convert.ToDouble(txtRadio.Text))}";
                    break;
                default:
                    MessageBox.Show("Por favor seleccione una opcion del comboBox","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregue un comentario en el Button1.CLick
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    circulo.CambiarColor(colorDialog1.Color);
                }
                else
                {
                    cilindro.CambiarColor(colorDialog1.Color);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label4.Visible = false;
                    txtAltura.Visible = false; 
                    break;
                case 1:
                    label4.Visible = true;
                    txtAltura.Visible = true; 
                    break;
            }
        }
    }
}
