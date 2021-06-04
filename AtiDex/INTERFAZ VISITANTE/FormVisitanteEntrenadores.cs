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
        private string Nombre = "";
        private string Apellido1 = "";
        private string Provincia = "";
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
            CdN_Pokemon Usuario = new CdN_Pokemon();
            dataGridView1.DataSource = Usuario.visitanteEntrenador(Nombre,Apellido1,Provincia);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Nombre = textBox1.Text;
                Apellido1 = textBox2.Text;
                Provincia = textBox3.Text;
                MostrarUsuarios();
            }
            catch
            {

                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:");

            }
        }
    }
}
