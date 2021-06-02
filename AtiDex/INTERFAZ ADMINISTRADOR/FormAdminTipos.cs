using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaDeNegocio;

namespace Atidex
{
    public partial class FormAdminTipos : Form
    {
        CN_Tipos objetoCN = new CN_Tipos();
        public FormAdminTipos()
        {
            InitializeComponent();
        }

        private void FormAdminTipos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.MostrarTipo();
        }
    }
}
