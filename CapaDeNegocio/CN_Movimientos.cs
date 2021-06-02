/* 
Proyecto: ATIDEX
Capa de Negocio para los movimientos

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class CN_Movimientos
    {
        private CD_Movimientos movimientoCD = new CD_Movimientos();

        public DataTable MostrarMov(){
            DataTable tabla = new DataTable();
            tabla = movimientoCD.Mostrar();
            return tabla;
        }

        public void InsertarMovimiento(string nombreMovimiento, string descripcionMovimiento, string TipoID){ // Manipula datos de insertar. Solo recibe Strings (Proviene del usuario)
            movimientoCD.InsertarMovimientos(nombreMovimiento, descripcionMovimiento, Convert.ToInt32(TipoID)); //Realiza conversiones de tipos en capa de negocio
        }

        public void editarMovimiento(string nombreMovimiento, string descripcionMovimiento, string TipoID, string MovimientoID) {// Manipula datos de editar. Solo recibe Strings (Proviene del usuario)
            movimientoCD.EditarMovimientos(nombreMovimiento, descripcionMovimiento, Convert.ToInt32(TipoID), Convert.ToInt32(MovimientoID));
        }

        public void eliminarMovimiento(string MovimientoID){ // Manipula datos de editar. Solo recibe Strings (Proviene del usuario)
            movimientoCD.EliminarMovimientos(Convert.ToInt32(MovimientoID));
        }
    }
}
