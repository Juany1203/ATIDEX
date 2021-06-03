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
    public partial class FormPokemones : Form
    {
        CdN_Pokemon TRainerPokemon = new CdN_Pokemon();
        public FormPokemones()
        {
            InitializeComponent();
        }
        private void FormPokemones_Load(object sender, EventArgs e)
        {
            MostrarPokemon();
        }
        private void MostrarPokemon()
        {
            CdN_Pokemon Pokemon = new CdN_Pokemon();
            dataGridView1.DataSource = Pokemon.MostrarProd();

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                TRainerPokemon.InsertarTrainerPokemon(textBoxPokemonID.Text, textBoxNickName.Text, textBoxHP.Text, textBoxATK.Text, textBoxDEF.Text, textBoxSATK.Text, textBoxSDEF.Text, textBoxVELOCIDAD.Text, checkBoxENequipo.Checked);
                LimpiarForm();
                MessageBox.Show("El dato se insertó correctamente");
            }
            

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);

            }

        }
        private void LimpiarForm()
        {
            textBoxPokemonID.Clear();
            textBoxNickName.Clear();
            textBoxHP.Clear();
            textBoxATK.Clear();
            textBoxDEF.Clear();
            textBoxSATK.Clear();
            textBoxSDEF.Clear();
            textBoxVELOCIDAD.Clear();
        }
    }
}
