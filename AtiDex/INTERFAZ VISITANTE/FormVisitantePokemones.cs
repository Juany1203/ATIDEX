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
    public partial class FormVisitantePokemones : Form
    {
        private string Nombre = "";
        private string generacion = "";

        public FormVisitantePokemones()
        {
            InitializeComponent();
        }

        private void FormVisitantePokemones_Load(object sender, EventArgs e)
        {
            MostrarPokemon();
        }
        private void MostrarPokemon()
        {
            CdN_Pokemon pokemon = new CdN_Pokemon();
            dataGridView1.DataSource = pokemon.visitantePokemon(Nombre,generacion);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Nombre = textBox1.Text;
                generacion = textBox2.Text;
                MostrarPokemon();
            }
            catch
            {

                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:");

            }
        }
    }
}
