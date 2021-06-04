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
            dataGridView1.DataSource = pokemon.MostrarProd();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
