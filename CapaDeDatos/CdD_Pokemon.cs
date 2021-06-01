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
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar(string nombrePokemon, string generacionPokemon, string legendarioPokemon, Image imagenPokemon)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePokemon", nombrePokemon);
            comando.Parameters.AddWithValue("@dgeneracionPokemon", generacionPokemon);
            comando.Parameters.AddWithValue("@legendarioPokemon", legendarioPokemon);
            comando.Parameters.AddWithValue("@imagenPokemon", imagenPokemon);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(string nombrePokemon, string generacionPokemon, string legendarioPokemon, Image imagenPokemon, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePokemon", nombrePokemon);
            comando.Parameters.AddWithValue("@dgeneracionPokemon", generacionPokemon);
            comando.Parameters.AddWithValue("@legendarioPokemon", legendarioPokemon);
            comando.Parameters.AddWithValue("@imagenPokemon", imagenPokemon);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int id)
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