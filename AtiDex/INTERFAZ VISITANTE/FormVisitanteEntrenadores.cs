using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using CapaDeNegocio;
using CapaComun.Cache;
using System.Windows.Forms;

namespace Atidex

{
    public partial class FormVisitanteEntrenadores : Form
    {
        public FormVisitanteEntrenadores()
        {
            InitializeComponent();
        }

        private void FormVisitanteEntrenadores_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            CN_Usuario Usuario = new CN_Usuario();
            dataGridView1.DataSource = Usuario.MostrarUsuario();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
