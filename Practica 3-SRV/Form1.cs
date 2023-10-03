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

namespace Practica_3_SRV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = textBox1.Text;
            string apellidos = textBox2.Text;
            string edad = textBox3.Text;
            string estatura = textBox4.Text;
            string telefono = textBox5.Text;

            string genero = "";
            if (checkBox1.Checked)
            {
                genero = "Hombre";
            }
            else if (checkBox2.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombres: {nombres} \r\nApellidos: {apellidos}\r\nTelefono: {telefono} kg\r\nApellidos: {estatura} cm\r\nApellidos: {edad} años\r\nGenero: {genero}";
            string rutaArchivo = "C://Users//Sebastian//P. Avanzada/3M.txt";
            bool archivoExiste = File.Exists(rutaArchivo);
            Console.WriteLine(archivoExiste);
            if (archivoExiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
            }

            MessageBox.Show("Datos guardados con exito: \n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
    }
}
