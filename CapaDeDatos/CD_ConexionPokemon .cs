/* 
Proyecto: ATIDEX
Conexion capa de datos con SQL para gestion de pokemones

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
    public class CD_ConexionPokemon
    {
        private SqlConnection Conexion = new SqlConnection("Server=(local);DataBase= AtiDex;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
