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
        private string Nombre = "";
        CN_Movimientos movimientoCN = new CN_Movimientos();
        public FormVisitanteMovimientos()
        {
            InitializeComponent();
        }

        private void MostrarMovimientos()
        {
            CdN_Pokemon movimiento = new CdN_Pokemon(); // Se utiliza para refrecar el metodo y evitar duplicar tabla
            dataGridView1.DataSource = movimiento.VisitanteMovimiento(Nombre); // Muestra elementos en pantalla
        }

        private void FormVisitanteMovimientos_Load(object sender, EventArgs e)
        {
            MostrarMovimientos(); // Invoca al metodo MostrarMovimientos
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Nombre = textBox1.Text;
                MostrarMovimientos();
            }
            catch
            {
                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:");

            }
        }
    }
}
    