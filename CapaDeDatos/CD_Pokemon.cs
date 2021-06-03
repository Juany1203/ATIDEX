using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CapaDeDatos;
using System.Drawing;
using CapaComun.Cache;

namespace CapaDeDatos
{
    public class CdD_Pokemon
    {
        private CD_ConexionPokemon conexion = new CD_ConexionPokemon();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        int IDEntrenador = UserLoginCache.IdUser;

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }
        public void InsertarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon)
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
        public void EditarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon, int id)
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
            comando.Parameters.AddWithValue("@PokemonIDEliminar", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        //Funciones para trainer pokemon
        public DataTable MostrarTrainerPokemon()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTrainerPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }
        public void InsertarTrainerPokemon( int PokemonID, string NickName, string salud, string ataque, string defensa, string atkspecial, string defspecial, string velocidad, bool Estado)
        {
            int EstadoP = 0;



            if (Estado == true)
            {
                EstadoP = 1;
            }
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "InsertarTrainerPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@EntrenadorID", IDEntrenador);
            comando.Parameters.AddWithValue("@PokemonID", PokemonID);
            comando.Parameters.AddWithValue("@NickName", PokemonID);
            comando.Parameters.AddWithValue("@Salud", salud);
            comando.Parameters.AddWithValue("@Ataque", ataque);
            comando.Parameters.AddWithValue("@Defensa", defensa);
            comando.Parameters.AddWithValue("@ATKespecial", atkspecial);
            comando.Parameters.AddWithValue("@DEFespecial", defspecial);
            comando.Parameters.AddWithValue("@Velocidad", velocidad);
            comando.Parameters.AddWithValue("@EstadoPokemon", EstadoP);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


            conexion.CerrarConexion();
        }
        public void EditarTrainerPokemon(int IDTrainerPokemon, int PokemonID, string NickName, string salud, string ataque, string defensa, string atkspecial, string defspecial, string velocidad, bool Estado)
        {
            int EstadoP = 0;
            if (Estado == true)
            {
                EstadoP = 1;
            }
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "EditarTrainerPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TrainerPokemonID", IDTrainerPokemon);
            comando.Parameters.AddWithValue("@EntrenadorID", IDEntrenador);
            comando.Parameters.AddWithValue("@PokemonID", PokemonID);
            comando.Parameters.AddWithValue("@NickName", PokemonID);
            comando.Parameters.AddWithValue("@Salud", salud);
            comando.Parameters.AddWithValue("@Ataque", ataque);
            comando.Parameters.AddWithValue("@Defensa", defensa);
            comando.Parameters.AddWithValue("@ATKespecial", atkspecial);
            comando.Parameters.AddWithValue("@DEFespecial", defspecial);
            comando.Parameters.AddWithValue("@Velocidad", velocidad);
            comando.Parameters.AddWithValue("@EstadoPokemon", EstadoP);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarTrainerPokemon(int TrainerPokemonid)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarTrainerPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TrainerPokemon", TrainerPokemonid);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


    }
}
