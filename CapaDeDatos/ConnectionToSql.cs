/* 
Proyecto: ATIDEX
Conexion capa de datos con SQL
Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System;

namespace CapaDeDatos
    
{
    public class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Server=(local) ;DataBase= AtiDex; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        


    }
    public class CD_Conexion
    {
        private SqlConnection conexion = new SqlConnection("Server=(local);DataBase= AtiDex; integrated security = true");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
