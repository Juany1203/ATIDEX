using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaDeNegocio;

namespace Atidex
{
    public partial class FormRegistro : Form
    {
        
        CN_Usuario UsuarioCN = new CN_Usuario();
        private string idUsuario = Convert.ToString(UserLoginCache.IdUser);


        public FormRegistro()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfazDelEntrenador interfazE = new InterfazDelEntrenador();
            try
            {
                    UsuarioCN.InsertarUsuario(UserTextBox.Text, PassTextBox.Text, false, NombreTextBox.Text, Apellido1TextBox.Text, Apellido2TextBox.Text, ProvinciaTextBox.Text, CantonTextBox.Text, DistritoTextBox.Text, DireccionTextBox.Text, TelefonoTextBox.Text, EmailtextBox.Text, SitioWebTextBox.Text, FacebookTextBox.Text, TwiterTextBox.Text, InstagramTextBox.Text);
                    MessageBox.Show("Se registro Correctamente");
                    this.Close();
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);
            }
        }
    }
}
