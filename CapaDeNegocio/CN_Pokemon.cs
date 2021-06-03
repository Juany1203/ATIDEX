﻿using System;
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
        public void InsertarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon)
        {
            objetoCD.InsertarPokemon(nombrePokemon, generacionPokemon, legendarioPokemon, imagenPokemon);
        }
        public void EditarPokemon(string nombrePokemon, string generacionPokemon, bool legendarioPokemon, byte[] imagenPokemon, string id)
        {
            objetoCD.EditarPokemon(nombrePokemon, generacionPokemon, legendarioPokemon, imagenPokemon, Convert.ToInt32(id));
        }

        public void EliminarPokemon(string id)
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
        public void InsertarTrainerPokemon(string PokemonID, string NickName, string salud, string ataque, string defensa, string atkspecial, string defspecial, string velocidad, bool Estado)
        {
            objetoCD.InsertarTrainerPokemon(Convert.ToInt32(PokemonID), NickName, salud, ataque, defensa, atkspecial, defspecial, velocidad, Estado);

        }
        public void EditarTrainerPokemon(string IDTrainerPokemon, string PokemonID, string NickName, string salud, string ataque, string defensa, string atkspecial, string defspecial, string velocidad, bool Estado)
        {
            objetoCD.EditarTrainerPokemon(Convert.ToInt32(IDTrainerPokemon), Convert.ToInt32(PokemonID), NickName, salud, ataque, defensa, atkspecial, defspecial, velocidad, Estado);

        }
        public void EliminarTrainerPokemon(string IDTrainerPokemon)
        {
            objetoCD.EliminarTrainerPokemon(Convert.ToInt32(IDTrainerPokemon));
        }

    }
}
