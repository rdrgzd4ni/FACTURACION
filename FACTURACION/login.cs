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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salirapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario6 = new Inicio();
            formulario6.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
