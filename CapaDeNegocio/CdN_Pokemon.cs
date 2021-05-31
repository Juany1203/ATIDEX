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
        //  private CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        tabla = objetoCD.Mostrar();
        return tabla;
    }
    public void InsertarPokemon(string nombrePokemon, string generacionPokemon, string legendarioPokemon, Image imagenPokemon)
    {
        objetoCD.Insertar(nombrePokemon, generacionPokemon, legendarioPokemon,imagenPokemon);
    }
    public void EditarPokemon(string nombrePokemon, string generacionPokemon, string legendarioPokemon, Image imagenPokemon, string id)
    {
        objetoCD.Editar(nombrePokemon, generacionPokemon, legendarioPokemon, imagenPokemon, Convert.ToInt32(id));
    }
    public void EliminarPokemon (string id)
    {
        objetoCD.Eliminar (Convert.ToInt32(id))
    }
}
