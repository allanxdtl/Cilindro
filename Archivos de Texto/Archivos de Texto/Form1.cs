using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archivos_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            TextWriter write = new StreamWriter("test.txt");
            write.WriteLine("Puto el que lo lea");
            write.Close();
            MessageBox.Show("Listo!");

            StreamWriter add = File.AppendText("test.txt");
            add.WriteLine("Nueva Linea add");
            add.WriteLine("Este es mi primer archivo de texto");
            add.Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader read = new StreamReader("test.txt");
            //tambien se puede utilizar el ReadLine(), pero solo imprime el primer renglon
            MessageBox.Show(read.ReadToEnd(),"Contenido del archivo de texto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            read.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Busca tu archivo";
                openFileDialog1.ShowDialog();
                if (File.Exists(openFileDialog1.FileName))
                {
                    string texto = openFileDialog1.FileName;
                    TextReader read = new StreamReader(texto);
                    richTextBox1.Text = read.ReadToEnd();
                    read.Close();
                    txtDireccion.Text = texto;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir", "Atencion", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textSave = File.CreateText(txt);
                        textSave.Write(richTextBox1.Text);
                        textSave.Flush();
                        textSave.Close();
                        txtDireccion.Text = txt;
                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textSave = File.CreateText(txt);
                        textSave.Write(richTextBox1.Text);
                        textSave.Flush();
                        textSave.Close();
                        txtDireccion.Text = txt;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario2 ventana = new Formulario2();
            ventana.Show();
            
        }
    }
}
