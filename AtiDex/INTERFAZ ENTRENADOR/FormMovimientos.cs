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

        private void MostrarDatos()
        {
            CdN_Pokemon TrainerPokemon = new CdN_Pokemon();
            dataGridViewPokemones.DataSource = TrainerPokemon.MostrarTrainerPokemon();
            CN_Movimientos movimiento = new CN_Movimientos(); // Se utiliza para refrecar el metodo y evitar duplicar tabla
            dataGridViewMovimientos.DataSource = movimiento.MostrarMov(); // Muestra elementos en pantalla
            CdN_Pokemon TrainerPokemonMov = new CdN_Pokemon();
            dataGridViewMovimientosPokemon.DataSource = TrainerPokemonMov.MostrarTrainerPokemonMov();
        }

        private void btnGuardar_Click(object sender, EventArgs e) // Evento al clickear botón Guardar
        {
            if (EditarUsuario == false) // En caso de agregar un nuevo elemento
            {
                if (textBoxPokemonID.Text=="")
                    MessageBox.Show("Ingrese por favor un Id pokemon");
                else
                {
                    if (textBoxMovimientosID.Text == "")
                        MessageBox.Show("Ingrese por favor un Id movimiento");
                    else
                    {

                        try
                        {
                            TrainerModif.InsertarTrainerPokemonMov(textBoxPokemonID.Text, textBoxMovimientosID.Text);
                            MessageBox.Show("El dato se Insertó correctamente");
                            MostrarDatos();
                            Limpiarform();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("No se pudo insertar,verifique si los valores ingresados forman parte de los pokemones y movimientos");

                        }

                    }


                }

            }
            if (EditarUsuario == true) // En caso de modificar un elemento existente 
            {
                if (textBoxPokemonID.Text == "")
                    MessageBox.Show("Ingrese por favor un Id pokemon");
                else
                {
                    if (textBoxMovimientosID.Text == "")
                        MessageBox.Show("Ingrese por favor un Id movimiento");
                    else
                    {
                        try
                        {
                            TrainerModif.EditarTrainerPokemonMov(PokemonMovID, textBoxPokemonID.Text, textBoxMovimientosID.Text);
                            MessageBox.Show("El dato se modificó correctamente");
                            MostrarDatos();
                            Limpiarform();
                            EditarUsuario = false;

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("No se pudo insertar, verifique si los valores ingresados forman parte de los pokemones y movimientos");

                        }

                    }


                }
               
            }
        }
        private void Limpiarform() // Funcion para limpiar las cajas de texto despues de una transacción
        {
            textBoxMovimientosID.Clear();
            textBoxPokemonID.Clear();
        }

        private void button3_Click(object sender, EventArgs e) // Evento al clickear botón Eliminar
        {
            if (dataGridViewMovimientosPokemon.SelectedRows.Count > 0)
            {
                if (dataGridViewMovimientosPokemon.SelectedRows.ToString() == null)
                {
                    MessageBox.Show("No se pudo eliminar, por favor intente de nuevo");

                }
                else
                {
                    PokemonMovID = dataGridViewMovimientosPokemon.CurrentRow.Cells["MovPokemonID"].Value.ToString();
                    TrainerModif.EliminarTrainerPokemonMov(PokemonMovID);
                    MessageBox.Show("El dato se eliminó correctamente");
                    MostrarDatos();
                    Limpiarform();


                }


            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void button2_Click(object sender, EventArgs e) // Evento al clickear botón Modificar
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

        private void dataGridViewPokemones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
