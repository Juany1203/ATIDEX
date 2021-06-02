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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPASS_MouseEnter(object sender, EventArgs e)
        {
            TextBoxPASS.UseSystemPasswordChar = true;
        }

        private void BotonACCEDER_Click(object sender, EventArgs e)
        {
            if (TextboxUSER.Text != "")
            {
                if (TextBoxPASS.Text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(TextboxUSER.Text, TextBoxPASS.Text);
                    if (validLogin == true)
                    {
                        if (UserLoginCache.TipoUsuario == true)
                        {
                            this.Hide();
                            FormLoading formLoading = new FormLoading();
                            formLoading.ShowDialog();
                            InterfazDelAdmin mainMenu = new InterfazDelAdmin();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            
                        }
                        else
                        {
                            this.Hide();
                            FormLoading formLoading = new FormLoading();
                            formLoading.ShowDialog();
                            InterfazDelEntrenador mainMenu = new InterfazDelEntrenador();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;

                        }
                    }
                    else
                    {
                        msgError("El username o la contraseña son incorrectos");
                        TextBoxPASS.Clear();
                        TextboxUSER.Focus();
                    }
                }
                else msgError("Por favor ingrese una contraseña");

            }
            else
                msgError("Por favor ingrese un username");
        }
        private void msgError (string msg)
        {
            ErrorMessage.Text = msg;
            ErrorMessage.Visible = true;
        }
        private void Logout (object sender, FormClosedEventArgs e)
        {
            TextBoxPASS.Clear();
            TextboxUSER.Clear();
            ErrorMessage.Visible = false;
            this.Show();
            TextboxUSER.Focus();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkVISITANTE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLoading formLoading = new FormLoading();
            formLoading.ShowDialog();
            InterfazDelVisitante mainMenu = new InterfazDelVisitante();
            mainMenu.Show();
            mainMenu.FormClosed += Logout;
        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro Registro = new FormRegistro();
            Registro.Show();
            Registro.FormClosed += Logout;
            this.Hide();

        }
    }
}
