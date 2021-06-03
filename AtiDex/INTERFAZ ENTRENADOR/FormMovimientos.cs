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
    public partial class FormMovimientos : Form
    {
        private bool EditarUsuario = false;
        CdN_Pokemon TrainerModif = new CdN_Pokemon();
        private string trainerPokemonID;
        private string EntrenadorID = "";
        private string PokemonMovID = "";

        public FormMovimientos()
        {
            InitializeComponent();
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            MostrarDatos(); // Invoca al metodo MostrarMovimientos
        }


        private void dataGridViewMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridViewPokemones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarDatos()
        {
            CdN_Pokemon TrainerPokemon = new CdN_Pokemon();
            dataGridViewPokemones.DataSource = TrainerPokemon.MostrarTrainerPokemon();
            CN_Movimientos movimiento = new CN_Movimientos(); // Se utiliza para refrecar el metodo y evitar duplicar tabla
            dataGridViewMovimientos.DataSource = movimiento.MostrarMov(); // Muestra elementos en pantalla
            CdN_Pokemon TrainerPokemonMov = new CdN_Pokemon();
            dataGridViewMovimientosPokemon.DataSource = TrainerPokemonMov.MostrarTrainerPokemonMov();
        }

        private void dataGridViewMovimientosPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EditarUsuario == false)
            {
                try
                {
                    TrainerModif.InsertarTrainerPokemonMov(textBoxPokemonID.Text,textBoxMovimientosID.Text);
                    MessageBox.Show("El dato se Insertó correctamente");
                    MostrarDatos();
                    Limpiarform();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);

                }
            }
            if (EditarUsuario == true)
            {
                try
                {
                    TrainerModif.EditarTrainerPokemonMov(PokemonMovID, textBoxPokemonID.Text, textBoxMovimientosID.Text);
                    MessageBox.Show("El dato se modificó correctamente");
                    MostrarDatos();
                    Limpiarform();
                    EditarUsuario = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);

                }
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {


        }
        private void Limpiarform()
        {
            textBoxMovimientosID.Clear();
            textBoxPokemonID.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovimientosPokemon.SelectedRows.Count > 0)
            {
                PokemonMovID = dataGridViewMovimientosPokemon.CurrentRow.Cells["MovPokemonID"].Value.ToString();
                TrainerModif.EliminarTrainerPokemonMov(PokemonMovID);
                MessageBox.Show("El dato se eliminó correctamente");
                MostrarDatos();
                Limpiarform();


            }
            else
                MessageBox.Show("Seleccione una fila por favor");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridViewMovimientosPokemon.SelectedRows.Count > 0)
            {
                EditarUsuario = true;

                PokemonMovID = dataGridViewMovimientosPokemon.CurrentRow.Cells["MovPokemonID"].Value.ToString();
                textBoxPokemonID.Text = dataGridViewMovimientosPokemon.CurrentRow.Cells["TrainerPokemon_IntermediaID"].Value.ToString();
                textBoxMovimientosID.Text = dataGridViewMovimientosPokemon.CurrentRow.Cells["Movimiento_IntermediaID"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");


        }
    }
}
