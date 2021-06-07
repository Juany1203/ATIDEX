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
    public partial class btnEditar : Form
    {
        CN_Tipos objetoCN = new CN_Tipos();
        private string TipoID = null;
        private bool Editar = false;
        public btnEditar()
        {
            InitializeComponent();
        }

        private void MostrarTipo()
        {
            CN_Tipos objetoTipo_CN = new CN_Tipos();
            dataGridView1.DataSource = objetoTipo_CN.MostrarTipo();

        }
        private void FormAdminTipos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.MostrarTipo();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //En la siguiente función, es donde se edita e insertan datos a la tabla de tipos
        private void button1_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                if (TipoNombre.Text =="")
                    MessageBox.Show("Por favor ingresar un nombre del tipo");
                else
                {
                    try
                    {
                        objetoCN.InsertarTipo(TipoNombre.Text);
                        MessageBox.Show("Se insertó correctamente");
                        MostrarTipo();
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar por: " + ex);
                    }

                }

            }
            //EDITAR
            if (Editar == true)
            {
                if (TipoNombre.Text == "")
                    MessageBox.Show("Por favor ingresar un nombre del tipo");
                else
                {
                    try
                    {
                        objetoCN.EditarTipo(TipoNombre.Text, TipoID);
                        MessageBox.Show("Se editó correctamente");
                        MostrarTipo();
                        Editar = false;
                        limpiarForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo insertar");
                    }

                }

            }
        }
        //En la siguiente función, es donde se selecciona la fila de la tabla de tipos que se desea editar
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                TipoNombre.Text = dataGridView1.CurrentRow.Cells["TipoNombre"].Value.ToString();
                TipoID = dataGridView1.CurrentRow.Cells["TipoID"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
        private void limpiarForm()
        {
            TipoNombre.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TipoID = dataGridView1.CurrentRow.Cells["TipoID"].Value.ToString();
                objetoCN.EliminarTipo(TipoID);
                MessageBox.Show
                    ("Se ha eliminado correctamente");
                MostrarTipo();


            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
    }
}
