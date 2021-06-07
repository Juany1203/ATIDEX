/* 
Proyecto: ATIDEX

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/

namespace Atidex
{
    partial class FormAdminMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMovimientos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombreMovimiento = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovimientos
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMovimientos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMovimientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMovimientos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMovimientos.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMovimientos.Name = "dataGridViewMovimientos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMovimientos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMovimientos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMovimientos.RowTemplate.Height = 29;
            this.dataGridViewMovimientos.Size = new System.Drawing.Size(438, 375);
            this.dataGridViewMovimientos.TabIndex = 0;
            this.dataGridViewMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovimientos_CellContentClick);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.Titulo.Location = new System.Drawing.Point(464, 34);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(314, 23);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Ingrese los datos del movimiento";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nombre.ForeColor = System.Drawing.Color.Maroon;
            this.Nombre.Location = new System.Drawing.Point(491, 81);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(85, 23);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombreMovimiento
            // 
            this.txtNombreMovimiento.Location = new System.Drawing.Point(639, 80);
            this.txtNombreMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreMovimiento.Name = "txtNombreMovimiento";
            this.txtNombreMovimiento.ShortcutsEnabled = false;
            this.txtNombreMovimiento.Size = new System.Drawing.Size(154, 23);
            this.txtNombreMovimiento.TabIndex = 4;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Descripcion.ForeColor = System.Drawing.Color.Maroon;
            this.Descripcion.Location = new System.Drawing.Point(491, 112);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(119, 23);
            this.Descripcion.TabIndex = 5;
            this.Descripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(639, 113);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(154, 23);
            this.txtDescripcion.TabIndex = 6;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.BackColor = System.Drawing.SystemColors.Control;
            this.Tipo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tipo.ForeColor = System.Drawing.Color.Maroon;
            this.Tipo.Location = new System.Drawing.Point(491, 146);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(85, 23);
            this.Tipo.TabIndex = 7;
            this.Tipo.Text = "Tipo (ID)";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(639, 146);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(154, 23);
            this.txtTipo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Maroon;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(491, 198);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(302, 38);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Maroon;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(18, 390);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(175, 38);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(219, 390);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 38);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormAdminMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.txtNombreMovimiento);
            this.Controls.Add(this.dataGridViewMovimientos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Titulo);
            this.Name = "FormAdminMovimientos";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovimientos;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombreMovimiento;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}