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
                    if (pictureBoxPokemon.Image == null)
                    {
                        MessageBox.Show("Ingrese Por favor Una imagen");
                    }

                    else 
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pictureBoxPokemon.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        PokemonCN.InsertarPokemon(textBoxNombre.Text, textBoxGeneracion.Text, checkBox1.Checked, ms.GetBuffer());

                    }

                    MostrarPokemon();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar, verifique si insertó todos los datos necesarios");

                }
            }
            if (EditarPokemon == true)
            {
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pictureBoxPokemon.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    IDPokemon = TablaPokemon.CurrentRow.Cells["PokemonID"].Value.ToString();

                    PokemonCN.EditarPokemon(textBoxNombre.Text, textBoxGeneracion.Text, checkBox1.Checked,ms.GetBuffer(), IDPokemon);
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
            if (TablaPokemon.SelectedRows.Count > 0)
            {
                IDPokemon = TablaPokemon.CurrentRow.Cells["PokemonID"].Value.ToString();
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
            TablaPokemon.DataSource = pokemon.MostrarProd();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TablaPokemon.SelectedRows.Count > 0)
            {
                EditarPokemon = true;

                textBoxNombre.Text = TablaPokemon.CurrentRow.Cells["NombrePokemon"].Value.ToString();
                textBoxGeneracion.Text = TablaPokemon.CurrentRow.Cells["GeneracionPokemon"].Value.ToString();

                //con esto obtengo la imagen 
                //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //Bitmap img = (Bitmap)TablaPokemon.CurrentRow.Cells[4].Value;
                //img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //pictureBoxPokemon.Image =  Image.FromStream(ms);

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
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    pictureBoxPokemon.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBoxPokemon_Click(object sender, EventArgs e)
        {

        }

    }
}
