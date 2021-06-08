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
            if (UserTextBox.Text == "")
                MessageBox.Show("Por favor ingresar un Username");
            else
            {
                if (PassTextBox.Text == "")
                    MessageBox.Show("Por favor ingresar una contraseña");
                else
                {
                    if (NombreTextBox.Text == "")
                        MessageBox.Show("Por favor ingresar un nombre");
                    else
                    {

                        if (Apellido1TextBox.Text == "")
                            MessageBox.Show("Por favor ingresar su apellido 1");
                        else
                        {
                            if (Apellido2TextBox.Text == "")
                                MessageBox.Show("Por favor ingresar su apellido 2");
                            else
                            {
                                if (ProvinciaTextBox.Text == "")
                                    MessageBox.Show("Por favor ingresar la provincia");
                                else
                                {

                                    if (CantonTextBox.Text == "")
                                        MessageBox.Show("Por favor ingresar un cantón");
                                    else
                                    {
                                        if (DistritoTextBox.Text == "")
                                            MessageBox.Show("Por favor ingresar un distrito");
                                        else
                                        {
                                            if (DireccionTextBox.Text == "")
                                                MessageBox.Show("Por favor ingresar una dirección exacta");
                                            else
                                            {
                                                if (TelefonoTextBox.Text == "")
                                                    MessageBox.Show("Por favor ingresar un telefono");
                                                else
                                                {
                                                    if (EmailtextBox.Text == "")
                                                        MessageBox.Show("Por favor ingresar un email");
                                                    else
                                                    {
                                                        try
                                                        {
                                                            UsuarioCN.InsertarUsuario(UserTextBox.Text, PassTextBox.Text, false, NombreTextBox.Text, Apellido1TextBox.Text, Apellido2TextBox.Text, ProvinciaTextBox.Text, CantonTextBox.Text, DistritoTextBox.Text, DireccionTextBox.Text, TelefonoTextBox.Text, EmailtextBox.Text, SitioWebTextBox.Text, FacebookTextBox.Text, TwiterTextBox.Text, InstagramTextBox.Text);
                                                            MessageBox.Show("Se registro Correctamente");
                                                            this.Close();

                                                        }
                                                        catch (Exception)
                                                        {
                                                            MessageBox.Show("No se pudo registrar, verifique si los datos fueron ingresados correctamente");
                                                        }

                                                    }


                                                }


                                            }


                                        }


                                    }

                                }


                            }


                        }


                    }


                }


            }
        }
    }
}
