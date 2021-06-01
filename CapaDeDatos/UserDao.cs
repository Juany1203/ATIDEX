using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaComun.Cache;



namespace CapaDeDatos
{
    //Funcion para conseguir los datos del sql
    public class UserDao : ConnectionToSql
    {

        public bool Login (String user, String pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuario where UserNameUsuario =@User and Password =@pass";
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.PassUsuario = reader.GetString(1);
                            UserLoginCache.PassUsuario = reader.GetString(2);
                            UserLoginCache.TipoUsuario = reader.GetBoolean(3);
                            /*UserLoginCache.NombreUsuario = reader.GetString(3);
                            UserLoginCache.Apellido1Usuario = reader.GetString(4);
                            UserLoginCache.Apellido2Usuario = reader.GetString(5); 
                            UserLoginCache.provinciaUsuario = reader.GetString(6);
                            UserLoginCache.cantonUsuario = reader.GetString(7); 
                            UserLoginCache.distritoUsuario = reader.GetString(8); 
                            UserLoginCache.direccionUsuario = reader.GetString(9);
                            UserLoginCache.telefonoUsuario = reader.GetString(10);
                            UserLoginCache.correoUsuario = reader.GetString(11);
                            UserLoginCache.sitiowebUsuario = reader.GetString(12);
                            UserLoginCache.perfilfbUsuario = reader.GetString(13);
                            UserLoginCache.perfiltwUsuario = reader.GetString(14);
                            UserLoginCache.perfiligUsuario= reader.GetString(15);*/

                        }

                        return true;
                    }
                    else
                        return false;

                }


            }

        }
    }

    //apartir de aca se van a introducir los datos de los usuarios para obtener los valores en la capa de presentacion

    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select *from Usuario";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar (string NombreUsuario, string Password,bool TipoUsuario,string nombreUsuario, string apellido1Usuario, string apellido2Usuario, string provinciaUsuario, string cantonUsuario, string distritoUsuario, string direccionUsuario, string telefonoUsuario, string correoElectronicoUsuario, string sitiowebUsuario, string perfilFBUsuario, string perfilTWUsuario, string perfilIGUsuario)
        {
            int TipoUsuarioInt = 0;
            comando.Connection = conexion.AbrirConexion();
            if (TipoUsuario == true)
            {
                TipoUsuarioInt = 1;
            }
            comando.CommandText = "Insert into Usuario values ('" + NombreUsuario + "','" + Password + "'," + TipoUsuarioInt + ",'" + nombreUsuario + "','" + apellido1Usuario + "','" + apellido2Usuario + "','" + provinciaUsuario + "','" + cantonUsuario + "', '" + distritoUsuario + "','" + direccionUsuario + "', '" + telefonoUsuario + "','" + correoElectronicoUsuario + "','" + sitiowebUsuario + "','" + perfilFBUsuario + "','" + perfilTWUsuario + "','" + perfilIGUsuario + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

        }




    }


}
