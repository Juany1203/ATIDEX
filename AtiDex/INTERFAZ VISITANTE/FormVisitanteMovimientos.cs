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
    public partial class FormVisitanteMovimientos : Form
    {
        CN_Movimientos movimientoCN = new CN_Movimientos();
        public FormVisitanteMovimientos()
        {
            InitializeComponent();
        }

        private void MostrarMovimientos()
        {
            CN_Movimientos movimiento = new CN_Movimientos(); // Se utiliza para refrecar el metodo y evitar duplicar tabla
            dataGridView1.DataSource = movimiento.MostrarMov(); // Muestra elementos en pantalla
        }

        private void FormVisitanteMovimientos_Load(object sender, EventArgs e)
        {
            MostrarMovimientos(); // Invoca al metodo MostrarMovimientos
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    