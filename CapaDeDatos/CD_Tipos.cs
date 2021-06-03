/* 
Proyecto: ATIDEX
Capa de datos para los movimientos

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class CD_Tipos
    {
        private CD_ConexionTipos conexion = new CD_ConexionTipos();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar() // Metodo de lectura de los tipos de pokemones de las tablas en sql 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select *from Tipo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string TipoNombre) // Funcion para insertar un nuevo tipo
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTipo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreTipo", TipoNombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void EditarTipo(string TipoNombre, int TipoID) // Funcion para modificar un tipo de pokemon existente
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarTipo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreTipo", TipoNombre );
            comando.Parameters.AddWithValue("@IdTipo", TipoID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EliminarTipo(int TipoID) // Funcion para eliminar un tipo existente
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarTipo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTipo", TipoID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
 