/* 
Proyecto: ATIDEX
Capa de Negocio para los tipos de pokemones

Elaborado por:
- Juan Carlos Álvarez Vieto
- Juan Andrés Fernández Camacho
- Marcelo Fernández Solano
- Steven Vega Zúñiga 
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDeDatos;


namespace CapaDeNegocio
{
    public class CN_Tipos
    {
        private CD_Tipos objetoCD = new CD_Tipos();

        public DataTable MostrarTipo()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarTipo (string TipoNombre) // Manipula datos de insertar. Solo recibe Strings (Proviene del usuario)
        {
            objetoCD.Insertar(TipoNombre);
    }
        public void EditarTipo(string TipoNombre, string TipoID) // Manipula datos de editar. Solo recibe Strings (Proviene del usuario)
        {
            objetoCD.EditarTipo(TipoNombre, Convert.ToInt32(TipoID));
               
        }
        public void EliminarTipo(string TipoID) // Manipula datos de eliminar. Recibe el ID en forma de string
        {
            objetoCD.EliminarTipo(Convert.ToInt32(TipoID));
        }

    }
}
