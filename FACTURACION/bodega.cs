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

    public partial class bodega : Form
    {
        Conexion c = new Conexion();
        public bodega()
        {
            InitializeComponent();
        }

        private void btn_atras2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario4 = new consulta();
            formulario4.Show();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario5 = new Inicio();
            formulario5.Show();
        }

        private void bodega_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
        }

        private void btn_agregarproducto_Click(object sender, EventArgs e)
        {
            if (c.productoRegistrado(Convert.ToInt32(textBox_idproducto.Text)) == 0)
            {
                MessageBox.Show(c.insertar(Convert.ToInt32(textBox_idproducto.Text),textBox_idproducto.Text ,textnombreproducto.Text, textBoxprecio.Text));
            }
            else
            {
                MessageBox.Show("No se puede registrar, ya existe");

            }
        }
    }
}
    