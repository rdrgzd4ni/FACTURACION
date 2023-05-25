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
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario3 = new Inicio();
            formulario3.Show();
        }

        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario4 = new bodega();
            formulario4.Show();
        }

        private void bodega_Load(object sender, EventArgs e)
        {

        }
    }
}
