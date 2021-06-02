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
    public partial class FormAdminPokemon : Form
    {
        CdN_Pokemon PokemonCN = new CdN_Pokemon();
        private string IDPokemon = null;
        private bool EditarPokemon = false;
        public FormAdminPokemon()
        {
            InitializeComponent();
        }

        private void FormAdminPokemon_Load(object sender, EventArgs e)
        {
            MostrarPokemon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EditarPokemon == false)
            {
                try
                {
                    PokemonCN.InsertarPokemon(textBoxNombre.Text, textBoxGeneracion.Text, checkBox1.Checked, pictureBoxPokemon.Image);
                    MostrarPokemon();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);

                }
            }
            if (EditarPokemon == true)
            {
                try
                {
                    IDPokemon = dataGridView1.CurrentRow.Cells["PokemonID"].Value.ToString();
                    PokemonCN.EditarPokemon(textBoxNombre.Text, textBoxGeneracion.Text, checkBox1.Checked, pictureBoxPokemon.Image, IDPokemon);
                    MessageBox.Show("El dato se modificó correctamente");
                    MostrarPokemon();
                    limpiarForm();
                    EditarPokemon = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);

                }
            }

        }

        //eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDPokemon = dataGridView1.CurrentRow.Cells["PokemonID"].Value.ToString();
                PokemonCN.EliminarPokemon(IDPokemon);
                MessageBox.Show("El dato se eliminó correctamente");
                MostrarPokemon();
                limpiarForm();

            }
            else
                MessageBox.Show("Seleccione una fila por favor");


        }
        private void limpiarForm()
        {
            textBoxNombre.Clear();
            textBoxGeneracion.Clear();


            }
        private void MostrarPokemon()
        {
            CdN_Pokemon pokemon = new CdN_Pokemon();
            dataGridView1.DataSource = pokemon.MostrarProd();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditarPokemon = true;

                textBoxNombre.Text = dataGridView1.CurrentRow.Cells["NombrePokemon"].Value.ToString();
                textBoxGeneracion.Text = dataGridView1.CurrentRow.Cells["GeneracionPokemon"].Value.ToString();
                var imageCell = (DataGridViewImageCell)dataGridView1.CurrentRow.Cells[3];
                Image value = (Image)imageCell.Value;
                pictureBoxPokemon.Image = value;
            }

            else
                MessageBox.Show("Seleccione una fila por favor");
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files (*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBoxPokemon.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
