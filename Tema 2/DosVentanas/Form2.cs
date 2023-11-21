using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosVentanas
{
    public partial class Form2 : Form
    {
        Form1 form1;
        BBDD miBaseDatos;
        DataRow fila;
        int posicion = 0;
        public Form2(Form1 form1, BBDD miBaseDatos)
        {
            InitializeComponent();
            this.form1 = form1;
            this.miBaseDatos = miBaseDatos;
            miBaseDatos.CargarTablaForestales();
            actualizarDatos();

            switch (miBaseDatos.numFilas())
            {
                case 0:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    break;
                case 1:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    break;
                default:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    break;
            }

        }

        private void actualizarDatos()
        {
            fila = miBaseDatos.obtenerFila(posicion);
            textBox1.Text = fila[0].ToString();
            textBox2.Text = fila[1].ToString();
            textBox3.Text = fila[2].ToString();
            textBox4.Text = fila[3].ToString();
            textBox5.Text = fila[4].ToString();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (posicion < miBaseDatos.numFilas() - 1)
            {
                posicion += 1;
                this.actualizarDatos();
                button1.Enabled = true;
                button2.Enabled = true;
                if(posicion==miBaseDatos.numFilas()-1){
                    button3.Enabled=false;
                    button4.Enabled = false;
                }
            }
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (posicion >= 0)
            {
                posicion -= 1;
                this.actualizarDatos();
                button3.Enabled = true;
                button4.Enabled = true;
                if (posicion == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            posicion = miBaseDatos.numFilas() - 1;
            this.actualizarDatos();
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            posicion = 0;
            this.actualizarDatos();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
        }
    }
}
