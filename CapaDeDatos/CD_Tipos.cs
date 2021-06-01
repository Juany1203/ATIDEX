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

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select *from Tipo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string TipoNombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "";
        }
    }
}
