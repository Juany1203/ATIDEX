/* 
Proyecto: ATIDEX
Capa de Negocio para los pokemomes

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
namespace CapaDeNegocio
{
    public class CdN_Pokemon
    {
        
        private CdD_Pokemon objetoCD = new CdD_Pokemon();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon) // Manipula datos de insertar. Recibe datos provienientes del usuario
        {
            objetoCD.InsertarPokemon(nombrePokemon, generacionPokemon, legendarioPokemon, imagenPokemon);
        }
        public void EditarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon, string id) // Manipula datos de modificar. Recibe datos provienientes del usuario
        {
            objetoCD.EditarPokemon(nombrePokemon, generacionPokemon, legendarioPokemon, imagenPokemon, Convert.ToInt32(id));
        }

        public void EliminarPokemon(string id) // Manipula datos de eliminar. Recive ID en fonra de string

        {
            objetoCD.EliminarPokemon(Convert.ToInt32(id));
        }
        //Trainer Pokemon funciones 
        public DataTable MostrarTrainerPokemon()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTrainerPokemon();
            return tabla;

        }
        public void InsertarTrainerPokemon(string PokemonID, string NickName, string salud, string ataque, string defensa, string atkspecial, string defspecial, string velocidad, bool Estado) // Manipula datos de insertar. Recibe datos provienientes del usuario
        {
            objetoCD.InsertarTrainerPokemon(Convert.ToInt32(PokemonID), NickName, salud, ataque, defensa, atkspecial, defspecial, velocidad, Estado);

        }
        public void EditarTrainerPokemon(string IDTrainerPokemon, string PokemonID, string NickName, string salud, string ataque, string defensa, string atkspecial, string defspecial, string velocidad, bool Estado) // Manipula datos de modificar. Recibe datos provienientes del usuario
        {
            objetoCD.EditarTrainerPokemon(Convert.ToInt32(IDTrainerPokemon), Convert.ToInt32(PokemonID), NickName, salud, ataque, defensa, atkspecial, defspecial, velocidad, Estado);

        }
        public void EliminarTrainerPokemon(string IDTrainerPokemon) // Manipula datos de eliminar. Recive ID en forma de string
        {
            objetoCD.EliminarTrainerPokemon(Convert.ToInt32(IDTrainerPokemon));
        }
        
        // Funciones para la tabla intermedia de Trainer Pokemon y Movimientos
        
        public DataTable MostrarTrainerPokemonMov() 
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarPokemonMov();
            return tabla;
        }
        public void InsertarTrainerPokemonMov (string trainerPokemonID, string MovID) // Manipula datos de insertar. Recibe datos provienientes del usuario
        {
            objetoCD.InsertarTrainerPokemonMov(Convert.ToInt32(trainerPokemonID), Convert.ToInt32(MovID));
        }
        public void EditarTrainerPokemonMov(string MovPokemonID, string trainerPokemonID, string MovID) // Manipula datos de modificar. Recibe datos provienientes del usuario
        {
            objetoCD.EditarTrainerPokemonMov(Convert.ToInt32(MovPokemonID), Convert.ToInt32(trainerPokemonID), Convert.ToInt32(MovID));
        }
        public void EliminarTrainerPokemonMov (string MovPokemonID) // Manipula datos de eliminar. Recive ID en forma de string
        {
            objetoCD.EliminarTrainerPokemonMov(Convert.ToInt32(MovPokemonID));
        }


    }
}
