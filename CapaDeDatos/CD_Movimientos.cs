/* 
Proyecto: ATIDEX
Capa de datos para los movimienots

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


namespace CapaDeDatos
{
    public class CD_Movimientos
    {
        private CD_ConexionMovimientos conexion = new CD_ConexionMovimientos();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar(){ // Metodo de lectura de los elementos de las tablas en sql 
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMovimientos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarMovimientos(string nombreMovimiento, string descripcionMovimiento, int TipoID){ // Funcion para insertar un nuevo movimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarMovimientos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreMovimiento", nombreMovimiento);
            comando.Parameters.AddWithValue("@descripcionMovimiento", descripcionMovimiento);
            comando.Parameters.AddWithValue("@TipoID", TipoID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarMovimientos(string nombreMovimiento, string descripcionMovimiento, int TipoID, int MovimientoID) // Funcion para modificar un movimiento existente
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarMovimientos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreMovimiento", nombreMovimiento);
            comando.Parameters.AddWithValue("@descripcionMovimiento", descripcionMovimiento);
            comando.Parameters.AddWithValue("@TipoID", TipoID);
            comando.Parameters.AddWithValue("@MovimientoID", MovimientoID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarMovimientos(int MovimientoID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarMovimientos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MovimientoID", MovimientoID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
