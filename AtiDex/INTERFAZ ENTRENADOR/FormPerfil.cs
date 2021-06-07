﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaDeNegocio;
using CapaPresentacion;


namespace Atidex
{
    public partial class FormPerfil : Form
    {
        
        CN_Usuario UsuarioCN = new CN_Usuario();
        private string idUsuario = Convert.ToString(UserLoginCache.IdUser);
        InterfazDelEntrenador Papa;


        public FormPerfil(InterfazDelEntrenador interfazDelEntrenador)
        {
            Papa = interfazDelEntrenador;
            InitializeComponent();
        }
        


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            actualizadorDeDatos();
        }
        private void actualizadorDeDatos()
        {
            UserTextBox.Text = UserLoginCache.UserUsuario.ToString();
            PassTextBox.Text = Convert.ToString(UserLoginCache.PassUsuario);
            NombreTextBox.Text = Convert.ToString(UserLoginCache.NombreUsuario);
            Apellido1TextBox.Text = Convert.ToString(UserLoginCache.Apellido1Usuario);
            Apellido2TextBox.Text = Convert.ToString(UserLoginCache.Apellido2Usuario);
            ProvinciaTextBox.Text = Convert.ToString(UserLoginCache.provinciaUsuario);
            CantonTextBox.Text = Convert.ToString(UserLoginCache.cantonUsuario);
            DistritoTextBox.Text = Convert.ToString(UserLoginCache.distritoUsuario);
            DireccionTextBox.Text = Convert.ToString(UserLoginCache.direccionUsuario);
            TelefonoTextBox.Text = Convert.ToString(UserLoginCache.telefonoUsuario);
            EmailtextBox.Text = Convert.ToString(UserLoginCache.correoUsuario);
            SitioWebTextBox.Text = Convert.ToString(UserLoginCache.sitiowebUsuario);
            FacebookTextBox.Text = Convert.ToString(UserLoginCache.perfilfbUsuario);
            TwiterTextBox.Text = Convert.ToString(UserLoginCache.perfiltwUsuario);
            InstagramTextBox.Text = Convert.ToString(UserLoginCache.perfiligUsuario);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserTextBox.Text == null)
            {
                MessageBox.Show("Ingrese Por favor el Username");

            }
            else
            {
                if (PassTextBox.Text == "")
                    MessageBox.Show("Ingrese Por favor la contraseña");
                else
                {
                    if (NombreTextBox.Text == "")
                        MessageBox.Show("Ingrese Por favor El Nombre");
                    else
                    {
                        if (Apellido1TextBox.Text == "")
                            MessageBox.Show("Ingrese Por favor El apellido 1");
                        else
                        {
                            if (Apellido2TextBox.Text == "")
                                MessageBox.Show("Ingrese Por favor El apellido 2");
                            else
                            {
                                if (ProvinciaTextBox.Text == "")
                                    MessageBox.Show("Ingrese Por favor la provincia");
                                else
                                {
                                    if (CantonTextBox.Text == "")
                                        MessageBox.Show("Ingrese Por favor el canton");
                                    else
                                    {
                                        if (DistritoTextBox.Text == "")
                                            MessageBox.Show("Ingrese Por favor El Distrito");
                                        else
                                        {
                                            if (DireccionTextBox.Text == "")
                                                MessageBox.Show("Ingrese Por favor la direccion");
                                            else
                                            {
                                                if (TelefonoTextBox.Text == "")
                                                    MessageBox.Show("Ingrese Por favor El telefono");
                                                else
                                                {
                                                    if (EmailtextBox.Text == "")
                                                        MessageBox.Show("Ingrese Por favor El email");
                                                    else
                                                    {
                                                        try
                                                        {

                                                            if (MessageBox.Show("¿Desea modificar el perfil? \n se cerrará la sesión.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                                            {
                                                                UsuarioCN.ModificarUsuario(idUsuario, UserTextBox.Text, PassTextBox.Text, false, NombreTextBox.Text, Apellido1TextBox.Text, Apellido2TextBox.Text, ProvinciaTextBox.Text, CantonTextBox.Text, DistritoTextBox.Text, DireccionTextBox.Text, TelefonoTextBox.Text, EmailtextBox.Text, SitioWebTextBox.Text, FacebookTextBox.Text, TwiterTextBox.Text, InstagramTextBox.Text);
                                                                Papa.Close();
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            MessageBox.Show("No se pudo insertar");
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

        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();


        }
        public void CerrarParentForm()
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("¿Desea Eliminar el perfil? \n Este Cambio no puede ser revertido.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    UsuarioCN.EliminarUser(idUsuario);
                    Papa.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar \n Se presenta el siguiente Error:" + ex);
            }

        }
    }
}
