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
    public partial class FormAdminUsuarios : Form
    {
        CN_Usuario UsuarioCN = new CN_Usuario();
        public FormAdminUsuarios()
        {
            InitializeComponent();
        }

        private void FormAdminUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();


        }

        private void MostrarUsuarios()
        {
            dataGridView1.DataSource = UsuarioCN.MostrarUsuario();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBoxAdmin.Checked)
            {
                checkBoxAdmin.Checked = true;
            }
            else
                checkBoxAdmin. = false;*/
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioCN.InsertarUsuario(textBoxUsername.Text, textBoxPass.Text, checkBoxAdmin.Checked, textBoxNombre.Text, textBoxApellido1.Text, textBoxApellido2.Text, textBoxProvincia.Text, textBoxCanton.Text, textBoxDistrito.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxEmail.Text, textBoxSitioWeb.Text, textBoxFacebook.Text, textBoxTwitter.Text, textBoxIG.Text);
                MessageBox.Show("El dato se insertó correctamente");
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:"+ex);

            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
