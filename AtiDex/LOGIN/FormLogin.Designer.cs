
namespace Atidex
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button BotonACCEDER;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextboxUSER = new System.Windows.Forms.TextBox();
            this.TextBoxPASS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkVISITANTE = new System.Windows.Forms.LinkLabel();
            this.linkRegistrar = new System.Windows.Forms.LinkLabel();
            BotonACCEDER = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonACCEDER
            // 
            BotonACCEDER.BackColor = System.Drawing.Color.White;
            BotonACCEDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BotonACCEDER.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BotonACCEDER.ForeColor = System.Drawing.Color.Maroon;
            BotonACCEDER.Location = new System.Drawing.Point(288, 209);
            BotonACCEDER.Name = "BotonACCEDER";
            BotonACCEDER.Size = new System.Drawing.Size(418, 43);
            BotonACCEDER.TabIndex = 7;
            BotonACCEDER.Text = "ACCEDER";
            BotonACCEDER.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            BotonACCEDER.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 324);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Diseño_sin_título__8_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextboxUSER
            // 
            this.TextboxUSER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxUSER.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextboxUSER.Location = new System.Drawing.Point(288, 73);
            this.TextboxUSER.Name = "TextboxUSER";
            this.TextboxUSER.Size = new System.Drawing.Size(418, 26);
            this.TextboxUSER.TabIndex = 2;
            this.TextboxUSER.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBoxPASS
            // 
            this.TextBoxPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPASS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPASS.Location = new System.Drawing.Point(288, 163);
            this.TextBoxPASS.Name = "TextBoxPASS";
            this.TextBoxPASS.Size = new System.Drawing.Size(418, 26);
            this.TextBoxPASS.TabIndex = 3;
            this.TextBoxPASS.MouseEnter += new System.EventHandler(this.TextBoxPASS_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(255, -80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(288, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(288, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONTRASEÑA";
            // 
            // linkVISITANTE
            // 
            this.linkVISITANTE.AutoSize = true;
            this.linkVISITANTE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkVISITANTE.LinkColor = System.Drawing.Color.Maroon;
            this.linkVISITANTE.Location = new System.Drawing.Point(408, 298);
            this.linkVISITANTE.Name = "linkVISITANTE";
            this.linkVISITANTE.Size = new System.Drawing.Size(163, 17);
            this.linkVISITANTE.TabIndex = 8;
            this.linkVISITANTE.TabStop = true;
            this.linkVISITANTE.Text = "Acceder como visitante";
            // 
            // linkRegistrar
            // 
            this.linkRegistrar.AutoSize = true;
            this.linkRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkRegistrar.LinkColor = System.Drawing.Color.Maroon;
            this.linkRegistrar.Location = new System.Drawing.Point(391, 270);
            this.linkRegistrar.Name = "linkRegistrar";
            this.linkRegistrar.Size = new System.Drawing.Size(195, 17);
            this.linkRegistrar.TabIndex = 11;
            this.linkRegistrar.TabStop = true;
            this.linkRegistrar.Text = "Registrarse como entrenador";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(764, 324);
            this.Controls.Add(this.linkRegistrar);
            this.Controls.Add(this.linkVISITANTE);
            this.Controls.Add(BotonACCEDER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPASS);
            this.Controls.Add(this.TextboxUSER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextboxUSER;
        private System.Windows.Forms.TextBox TextBoxPASS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkVISITANTE;
        private System.Windows.Forms.LinkLabel linkRegistrar;
    }
}