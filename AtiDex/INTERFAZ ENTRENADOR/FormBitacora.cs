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
    public partial class FormBitacora : Form
    {
        CN_Usuario UsuarioCN = new CN_Usuario();
        private int idUsuario = UserLoginCache.IdUser;
        public FormBitacora()
        {
            InitializeComponent();
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {
            MostrarBitacora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDia.Text == "")
                MessageBox.Show("por favor ingrese un día");
            else
            {
                if (textBoxMes.Text == "")
                    MessageBox.Show("por favor ingrese un mes");
                else
                {
                    if (textBoxAno.Text == "")
                        MessageBox.Show("por favor ingrese un año");
                    else
                    {
                        if (richTextBoxDesc.Text == "")
                            MessageBox.Show("por favor ingrese una descripción");
                        else
                        {
                            try
                            {
                                UsuarioCN.InsertarBit(textBoxDia.Text, textBoxMes.Text, textBoxAno.Text, richTextBoxDesc.Text);
                                MessageBox.Show("El dato se insertó correctamente");
                                MostrarBitacora();

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("No se pudo insertar");

                            }

                        }

                    }

                }

            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarBitacora();
        }
        private void MostrarBitacora()
        {
            CN_Usuario Usuario = new CN_Usuario();
            dataGridView1.DataSource = Usuario.MostrarBitacora();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
