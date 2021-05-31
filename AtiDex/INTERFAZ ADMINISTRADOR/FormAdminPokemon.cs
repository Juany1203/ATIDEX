using CapaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atidex
{
    public partial class FormAdminPokemon : Form
    {
        public FormAdminPokemon()
        {
            InitializeComponent();
        }

        private void FormAdminPokemon_Load(object sender, EventArgs e)
        {
            MostrarPokemon();
        }
        private void MostrarPokemon()
        {
            CdN_Pokemon objeto = new CdN_Pokemon();
            DataGridView.DataSource = objeto.MostrarProd();
        }
    }
}
