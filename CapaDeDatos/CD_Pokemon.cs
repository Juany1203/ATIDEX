/* 
Proyecto: ATIDEX
Capa de datos para los pokemones

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/


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
        private int IDEntrenador = UserLoginCache.IdUser;

        public DataTable Mostrar() // Metodo de lectura de los pokemones de las tablas en sql 
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }
        public void InsertarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon) // Funcion para insertar un nuevo pokemon
        {
            int Legendario = 0;



            if (legendarioPokemon == true)
            {
                Legendario = 1;
            }
            comando.Parameters.Clear();
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
        public void EditarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon, int id) // Funcion para modificar un pokemon existente
        {
            int Legendario = 0;

            if (legendarioPokemon == true)
            {
                Legendario = 1;
            }
            comando.Parameters.Clear();
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
        public void EliminarPokemon(int id) // Funcion para eliminar un movimiento existente
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
        public DataTable MostrarTrainerPokemon() // Método de lectura de  pokemones pertenecientes a entrenadores
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTrainerPokemon";

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@EntrenadorID", IDEntrenador);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarTrainerPokemon(int PokemonID, string NickName, string salud, string ataque, string defensa, string atkspecial, string defspecial, string velocidad, bool Estado) // Funcion para insertar un nuevo pokemon de un entrenador
        {
            int EstadoP = 0;



            if (Estado == true)
            {
                EstadoP = 1;
            }
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "InsertarTrainerPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@EntrenadorID", IDEntrenador);
            comando.Parameters.AddWithValue("@PokemonID", PokemonID);
            comando.Parameters.AddWithValue("@NickName", NickName);
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

        // Funcion para editar un pokemon de un entrenador
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
            comando.Parameters.AddWithValue("@NickName", NickName);
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
        public void EliminarTrainerPokemon(int TrainerPokemonid) // Funcion para eliminar un pokemon de un entrenador
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarTrainerPokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TrainerPokemon", TrainerPokemonid);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        // Funciones para la tabla intermedia de Pokemon y movimientos

        public DataTable MostrarPokemonMov()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTrainerPokemonMov";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@EntrenadorID", IDEntrenador);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarTrainerPokemonMov(int trainerPokemonID, int MovID)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertTrainerPokemonMov";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TrainerPokemonID", trainerPokemonID);
            comando.Parameters.AddWithValue("@MovimientosID", MovID);
            comando.Parameters.AddWithValue("@EntrenadorID", IDEntrenador);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarTrainerPokemonMov(int MovPokemonID, int trainerPokemonID, int MovID)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertTrainerPokemonMov";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TrainerPokemonMov", MovPokemonID);
            comando.Parameters.AddWithValue("@MovimientosID", trainerPokemonID);
            comando.Parameters.AddWithValue("@EntrenadorID", MovID);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarTrainerPokemonMov(int MovPokemonID)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarTrainerPokemonMov";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TrainerPokemonMov", MovPokemonID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public DataTable VisitanteEntrador(string Nombre, string apellido1, string provincia) // Método de lectura de  pokemones pertenecientes a entrenadores
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VisitanteEntrenador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido1", apellido1);
            comando.Parameters.AddWithValue("@provincia", provincia);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable VisitantePokemon(string Nombre, string generacion) // Método de lectura de  pokemones pertenecientes a entrenadores
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VisitantePokemon";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@generacion", generacion);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;


        }
        public DataTable VisitanteMovimiento(string Nombre ) // Método de lectura de  pokemones pertenecientes a entrenadores
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VisitanteMovimiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Nombre);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }


    }
}