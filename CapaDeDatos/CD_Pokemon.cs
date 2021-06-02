using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CapaDeDatos;
using System.Drawing;


namespace CapaDeDatos
{
    public class CdD_Pokemon
    {
        private CD_ConexionPokemon conexion = new CD_ConexionPokemon();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, Image imagenPokemon)
        {
            int Legendario = 0;

            if (legendarioPokemon == true)
            {
                Legendario = 1;
            }
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePokemon", nombrePokemon);
            comando.Parameters.AddWithValue("@generacionPokemon", generacionPokemon);
            comando.Parameters.AddWithValue("@legendarioPokemon", Legendario);
            comando.Parameters.AddWithValue("@imagenPokemon", imagenPokemon);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, Image imagenPokemon, int id)
        {
            int Legendario = 0;

            if (legendarioPokemon == true)
            {
                Legendario = 1;
            }

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePokemon", nombrePokemon);
            comando.Parameters.AddWithValue("@generacionPokemon", generacionPokemon);
            comando.Parameters.AddWithValue("@legendarioPokemon", Legendario);
            comando.Parameters.AddWithValue("@imagenPokemon", imagenPokemon);
            comando.Parameters.AddWithValue("@PokemonID", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarPokemon(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
