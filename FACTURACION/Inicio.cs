using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURACION
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

       // private void Form1_Load(object sender, EventArgs e)
     //   {
      //      btnsiguiente.Enabled = false;
      //  }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new registro();
            formulario.Show();
            //codigo para siguiente//
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      //error provider


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario2 = new consulta();
            formulario2.Show();
        }

        private void btn_agregar_a_bodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario7 = new bodega();
            formulario7.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form formulario = new registro();
            formulario.Show();
            //codigo para siguiente//
        }
    }
}
