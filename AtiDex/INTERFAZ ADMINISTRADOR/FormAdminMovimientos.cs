/* 
Proyecto: ATIDEX

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/

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
    public partial class FormAdminMovimientos : Form
    {

        CN_Movimientos movimientoCN = new CN_Movimientos();
        private string MovimientoID = null;
        private bool editarMovimiento = false; // Variable para comprovar si un movimiento ha sido editado
        public FormAdminMovimientos()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MostrarMovimientos(); // Invoca al metodo MostrarMovimientos
        }

        private void MostrarMovimientos(){
            CN_Movimientos movimiento = new CN_Movimientos(); // Se utiliza para refrecar el metodo y evitar duplicar tabla
            dataGridViewMovimientos.DataSource = movimiento.MostrarMov(); // Muestra elementos en pantalla
        }

        private void btnGuardar_Click(object sender, EventArgs e){ // Evento al clickear botón Guardar
            if(editarMovimiento == false){ // Si se trata de un nuevo movimiento, lo guarda en la base de datos
                try
                {
                    movimientoCN.InsertarMovimiento(txtNombreMovimiento.Text, txtDescripcion.Text, txtTipo.Text); //Guarda el contenido existente en las cajas de texto al presionar boton Guardar
                    MessageBox.Show("Los datos del movimiento han sido ingresados correctamente");
                    MostrarMovimientos();
                    limpiarformMovimientos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los datos no se guardaron exitosamente por el sigiente motivo: " + ex); //Explica el motivo por el cual no se pudo editar 
                }
            }
            if(editarMovimiento == true){ // Si se trata de editar un movimiento exitente
                try
                {
                    movimientoCN.editarMovimiento(txtNombreMovimiento.Text, txtDescripcion.Text, txtTipo.Text, MovimientoID);
                    MessageBox.Show("Los datos del movimiento han sido editados correctamente");
                    MostrarMovimientos();
                    limpiarformMovimientos();
                    editarMovimiento = false; // Reestablece el valor de editarMovimiento para seguir peritiendo el ingreso de valores nuevos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los datos no se editaron exitosamente por el sigiente motivo: " + ex); //Explica el motivo por el cual no se pudo guardar
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e){ // Evento al clickear botón Modificar
            if(dataGridViewMovimientos.SelectedRows.Count > 0){ //Asegura la seleccion de alguna fila
                txtNombreMovimiento.Text = dataGridViewMovimientos.CurrentRow.Cells["nombreMovimiento"].Value.ToString();
                txtDescripcion.Text = dataGridViewMovimientos.CurrentRow.Cells["descripcionMovimiento"].Value.ToString();
                txtTipo.Text = dataGridViewMovimientos.CurrentRow.Cells["TipoID"].Value.ToString();
                MovimientoID = dataGridViewMovimientos.CurrentRow.Cells["MovimientoID"].Value.ToString();
                editarMovimiento = true; // Se indica que el campo ya se ha editado
            }
            else{
                MessageBox.Show("Por favor seleccione la fila que desea editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            if (dataGridViewMovimientos.SelectedRows.Count > 0){ //Asegura la seleccion de alguna fila
                MovimientoID = dataGridViewMovimientos.CurrentRow.Cells["MovimientoID"].Value.ToString();
                movimientoCN.eliminarMovimiento(MovimientoID);
                MessageBox.Show("Los datos del movimiento han sido eliminados correctamente");
                MostrarMovimientos();


            }
            else{
                MessageBox.Show("Por favor seleccione la fila que desea eliminar");
            }
        }

        private void limpiarformMovimientos(){ // Limpia los textbox luego de cada transaccion
            txtNombreMovimiento.Clear();
            txtDescripcion.Clear();
            txtTipo.Clear();
        }

        private void dataGridViewMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
