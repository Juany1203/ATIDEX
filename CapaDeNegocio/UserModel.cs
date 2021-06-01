﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;
using System.Data.SqlClient;


namespace CapaDeNegocio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user,pass);

        }
    }
    public class CN_Usuario
    {
        private CD_Usuarios UsuarioCD = new CD_Usuarios();

        //funcion para mostrar los datos del Usuario
        public DataTable MostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = UsuarioCD.Mostrar();
            return tabla;
        }


        public void InsertarUsuario(string NombreUsuario, string Password, bool TipoUsuario, string nombreUsuario, string apellido1Usuario, string apellido2Usuario, string provinciaUsuario, string cantonUsuario, string distritoUsuario, string direccionUsuario, string telefonoUsuario, string correoElectronicoUsuario, string sitiowebUsuario, string perfilFBUsuario, string perfilTWUsuario, string perfilIGUsuario)
        {
            UsuarioCD.InsertarUsuarioCD(NombreUsuario, Password, TipoUsuario, nombreUsuario, apellido1Usuario, apellido2Usuario, provinciaUsuario, cantonUsuario, distritoUsuario, direccionUsuario, telefonoUsuario, correoElectronicoUsuario, sitiowebUsuario, perfilFBUsuario, perfilTWUsuario, perfilIGUsuario);
        }

        //funcion para modificar los datos del Usuario
        public void ModificarUsuario(string id,string NombreUsuario, string Password, bool TipoUsuario, string nombreUsuario, string apellido1Usuario, string apellido2Usuario, string provinciaUsuario, string cantonUsuario, string distritoUsuario, string direccionUsuario, string telefonoUsuario, string correoElectronicoUsuario, string sitiowebUsuario, string perfilFBUsuario, string perfilTWUsuario, string perfilIGUsuario)
        {
            UsuarioCD.EditarUsuario(Convert.ToInt32(id),NombreUsuario, Password, TipoUsuario, nombreUsuario, apellido1Usuario, apellido2Usuario, provinciaUsuario, cantonUsuario, distritoUsuario, direccionUsuario, telefonoUsuario, correoElectronicoUsuario, sitiowebUsuario, perfilFBUsuario, perfilTWUsuario, perfilIGUsuario);
        }
        public void EliminarUser(string IDUser)
        {
            UsuarioCD.EliminarUsuario(Convert.ToInt32(IDUser));
        }

    }


}
