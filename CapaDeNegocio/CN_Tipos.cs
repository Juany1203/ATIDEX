﻿using System;
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
        public void InsertarTipo (string TipoNombre)
        {
            objetoCD.Insertar(TipoNombre);
    }
        public void EditarTipo(string TipoNombre, string TipoID)
        {
            objetoCD.EditarTipo(TipoNombre, Convert.ToInt32(TipoID));
               
        }
        public void EliminarTipo(string TipoID)
        {
            objetoCD.EliminarTipo(Convert.ToInt32(TipoID));
        }

    }
}
