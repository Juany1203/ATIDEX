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
    public partial class FormConsulta : Form
    {
        CdN_Pokemon TrainerModif = new CdN_Pokemon();
        private string trainerPokemonID;
        private String PokemonID;

        public FormConsulta()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void FormConsulta_Load(object sender, EventArgs e)
        {
            MostrarTrainerPokemon();




        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                trainerPokemonID = dataGridView1.CurrentRow.Cells["TrainerPokemonID"].Value.ToString();
                PokemonID = dataGridView1.CurrentRow.Cells["PokemonID"].Value.ToString();
                textBoxNickname.Text = dataGridView1.CurrentRow.Cells["NickName"].Value.ToString();
                textBoxHP.Text = dataGridView1.CurrentRow.Cells["saludTrainerPokemon"].Value.ToString();
                textBoxATK.Text = dataGridView1.CurrentRow.Cells["ataqueTrainerPokemon"].Value.ToString();
                textBoxDEF.Text = dataGridView1.CurrentRow.Cells["defensaTrainerPokemon"].Value.ToString();
                textBoxSATK.Text = dataGridView1.CurrentRow.Cells["ataqueEspecialTrainerPokemon"].Value.ToString();
                textBoxSDEF.Text = dataGridView1.CurrentRow.Cells["defensaTrainerEspecialPokemon"].Value.ToString();
                textBoxVELOCIDAD.Text = dataGridView1.CurrentRow.Cells["velocidadTrainerPokemon"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void MostrarTrainerPokemon()
        {
            CdN_Pokemon TrainerPokemon = new CdN_Pokemon();
            dataGridView1.DataSource = TrainerPokemon.MostrarTrainerPokemon();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    string TrainerPokemondID = "";
                    TrainerPokemondID = dataGridView1.CurrentRow.Cells["TrainerPokemonID"].Value.ToString();


                    TrainerModif.EliminarTrainerPokemon(TrainerPokemondID);
                    MessageBox.Show("El dato se eliminó correctamente");
                    MostrarTrainerPokemon();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede eliminar un pokemon con movimientos asignados");

                }

            }
            else
                MessageBox.Show("Seleccione una fila por favor");

        }
        private void LimpiarForm()
        {
            textBoxNickname.Clear();
            textBoxHP.Clear();
            textBoxATK.Clear();
            textBoxDEF.Clear();
            textBoxSATK.Clear();
            textBoxSDEF.Clear();
            textBoxVELOCIDAD.Clear();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                TrainerModif.EditarTrainerPokemon(trainerPokemonID,PokemonID,textBoxNickname.Text,textBoxHP.Text,textBoxATK.Text,textBoxDEF.Text, textBoxSATK.Text,textBoxSDEF.Text,textBoxVELOCIDAD.Text,checkBoxESTATUS.Checked);
                MessageBox.Show("El dato se insertó correctamente");
                MostrarTrainerPokemon();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);

            }
        }
    }
}
