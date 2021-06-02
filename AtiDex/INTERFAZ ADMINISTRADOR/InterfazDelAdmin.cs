using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace Atidex
{
    public partial class InterfazDelAdmin : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public InterfazDelAdmin()
        {

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

        }

        // Metodos

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(160, 0, 0);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Botón izquierdo miedo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Cambio del icono

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(153, 0, 0);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void OpenChildForm(Form CHILDFORM)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = CHILDFORM;
            CHILDFORM.TopLevel = false;
            CHILDFORM.FormBorderStyle = FormBorderStyle.None;
            CHILDFORM.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(CHILDFORM);
            panelDesktop.Tag = CHILDFORM;
            CHILDFORM.BringToFront();
            CHILDFORM.Show();



        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(200, 120, 0));
            OpenChildForm (new FormAdminUsuarios());

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(200, 120, 0));
            OpenChildForm(new FormMovimientos());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(200, 120, 0));
            OpenChildForm(new FormAdminPokemon());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(200, 120, 0));
            OpenChildForm(new FormAdminTipos());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(200, 120, 0));
            OpenChildForm(new FormConsulta());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

        }

        private void TEXTODEBARASUPERIOR_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("¿Desea cerrar sesión?" , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }
    }

}