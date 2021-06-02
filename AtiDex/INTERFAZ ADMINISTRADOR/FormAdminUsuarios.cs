using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaDeNegocio;
using CapaComun.Cache;

namespace Atidex
{
    public partial class FormAdminUsuarios : Form
    {
        CN_Usuario UsuarioCN = new CN_Usuario();
        private string idUsuario = null;
        private bool EditarUsuario = false;
        


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
            CN_Usuario Usuario = new CN_Usuario();
            dataGridView1.DataSource = Usuario.MostrarUsuario();

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
            if (idUsuario == Convert.ToString(UserLoginCache.IdUser))
            {
                MessageBox.Show("No se puede editar el perfil que se esta utilizando");
                MostrarUsuarios();

            }
            else
            {
                if (EditarUsuario == false)
                {
                    try
                    {
                        UsuarioCN.InsertarUsuario(textBoxUsername.Text, textBoxPass.Text, checkBoxAdmin.Checked, textBoxNombre.Text, textBoxApellido1.Text, textBoxApellido2.Text, textBoxProvincia.Text, textBoxCanton.Text, textBoxDistrito.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxEmail.Text, textBoxSitioWeb.Text, textBoxFacebook.Text, textBoxTwitter.Text, textBoxIG.Text);
                        MessageBox.Show("El dato se insertó correctamente");
                        MostrarUsuarios();
                        limpiarForm();
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
                        UsuarioCN.ModificarUsuario(idUsuario, textBoxUsername.Text, textBoxPass.Text, checkBoxAdmin.Checked, textBoxNombre.Text, textBoxApellido1.Text, textBoxApellido2.Text, textBoxProvincia.Text, textBoxCanton.Text, textBoxDistrito.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxEmail.Text, textBoxSitioWeb.Text, textBoxFacebook.Text, textBoxTwitter.Text, textBoxIG.Text);
                        MessageBox.Show("El dato se modificó correctamente");
                        MostrarUsuarios();
                        limpiarForm();
                        EditarUsuario = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);

                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditarUsuario = true;

                textBoxUsername.Text = dataGridView1.CurrentRow.Cells["UserNameUsuario"].Value.ToString();
                textBoxPass.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                // checkBoxAdmin.Checked = dataGridView1.CurrentRow.Cells["TipoUsuario"].
                textBoxNombre.Text = dataGridView1.CurrentRow.Cells["nombreUsuario"].Value.ToString();
                textBoxApellido1.Text = dataGridView1.CurrentRow.Cells["apellido1Usuario"].Value.ToString();
                textBoxApellido2.Text = dataGridView1.CurrentRow.Cells["apellido2Usuario"].Value.ToString();
                textBoxProvincia.Text = dataGridView1.CurrentRow.Cells["provinciaUsuario"].Value.ToString();
                textBoxCanton.Text = dataGridView1.CurrentRow.Cells["cantonUsuario"].Value.ToString();
                textBoxDistrito.Text = dataGridView1.CurrentRow.Cells["distritoUsuario"].Value.ToString();
                textBoxDireccion.Text = dataGridView1.CurrentRow.Cells["direccionUsuario"].Value.ToString();
                textBoxTelefono.Text = dataGridView1.CurrentRow.Cells["telefonoUsuario"].Value.ToString();
                textBoxEmail.Text = dataGridView1.CurrentRow.Cells["correoElectronicoUsuario"].Value.ToString();
                textBoxSitioWeb.Text = dataGridView1.CurrentRow.Cells["sitiowebUsuario"].Value.ToString();
                textBoxFacebook.Text = dataGridView1.CurrentRow.Cells["perfilFBUsuario"].Value.ToString();
                textBoxTwitter.Text = dataGridView1.CurrentRow.Cells["perfilTWUsuario"].Value.ToString();
                textBoxIG.Text = dataGridView1.CurrentRow.Cells["perfilIGUsuario"].Value.ToString();
                idUsuario = dataGridView1.CurrentRow.Cells["UsuarioID"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor");

        }
        private void limpiarForm()
        {
            textBoxUsername.Clear();
            textBoxPass.Clear();
            textBoxNombre.Clear();
            textBoxApellido1.Clear();
            textBoxApellido2.Clear();
            textBoxProvincia.Clear();
            textBoxCanton.Clear();
            textBoxDistrito.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
            textBoxSitioWeb.Clear();
            textBoxFacebook.Clear();
            textBoxTwitter.Clear();
            textBoxIG.Clear();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idUsuario = dataGridView1.CurrentRow.Cells["UsuarioID"].Value.ToString();
                UsuarioCN.EliminarUser(idUsuario);
                MessageBox.Show("El dato se eliminó correctamente");
                MostrarUsuarios();
                limpiarForm();

            }
            else
                MessageBox.Show("Seleccione una fila por favor");


        }
    }
}
