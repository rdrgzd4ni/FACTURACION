﻿using System;
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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario1 = new Inicio();
            formulario1.Show();
            //codigo para atrás//
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
