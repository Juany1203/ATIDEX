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

        public void InsertarUsuarioCD (string NombreUsuario, string Password,bool TipoUsuario,string nombreUsuario, string apellido1Usuario, string apellido2Usuario, string provinciaUsuario, string cantonUsuario, string distritoUsuario, string direccionUsuario, string telefonoUsuario, string correoElectronicoUsuario, string sitiowebUsuario, string perfilFBUsuario, string perfilTWUsuario, string perfilIGUsuario)
        {
            int TipoUsuarioInt = 0;
            comando.Connection = conexion.AbrirConexion();
            if (TipoUsuario == true)
            {
                TipoUsuarioInt = 1;
            }
            comando.CommandText = "InsertarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Username",NombreUsuario);
            comando.Parameters.AddWithValue("@Password", Password);
            comando.Parameters.AddWithValue("@Tipo", TipoUsuarioInt);
            comando.Parameters.AddWithValue("@Nombre", nombreUsuario);
            comando.Parameters.AddWithValue("@Apellido1", apellido1Usuario);
            comando.Parameters.AddWithValue("@Apellido2", apellido2Usuario);
            comando.Parameters.AddWithValue("@Provincia", provinciaUsuario);
            comando.Parameters.AddWithValue("@Canton", cantonUsuario);
            comando.Parameters.AddWithValue("@Distrito", distritoUsuario);
            comando.Parameters.AddWithValue("@Direccion", direccionUsuario);
            comando.Parameters.AddWithValue("@Telefono", telefonoUsuario);
            comando.Parameters.AddWithValue("@Email", correoElectronicoUsuario);
            comando.Parameters.AddWithValue("@SitioWeb", sitiowebUsuario);
            comando.Parameters.AddWithValue("@Facebook", perfilFBUsuario);
            comando.Parameters.AddWithValue("@Twitter", perfilTWUsuario);
            comando.Parameters.AddWithValue("@IG", perfilIGUsuario);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarUsuario(int id, string NombreUsuario, string Password, bool TipoUsuario, string nombreUsuario, string apellido1Usuario, string apellido2Usuario, string provinciaUsuario, string cantonUsuario, string distritoUsuario, string direccionUsuario, string telefonoUsuario, string correoElectronicoUsuario, string sitiowebUsuario, string perfilFBUsuario, string perfilTWUsuario, string perfilIGUsuario)
        {
            int TipoUsuarioInt = 0;
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            if (TipoUsuario == true)
            {
                TipoUsuarioInt = 1;
            }
            comando.CommandText = "UpdateUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Username", NombreUsuario);
            comando.Parameters.AddWithValue("@Password", Password);
            comando.Parameters.AddWithValue("@Tipo", TipoUsuarioInt);
            comando.Parameters.AddWithValue("@Nombre", nombreUsuario);
            comando.Parameters.AddWithValue("@Apellido1", apellido1Usuario);
            comando.Parameters.AddWithValue("@Apellido2", apellido2Usuario);
            comando.Parameters.AddWithValue("@Provincia", provinciaUsuario);
            comando.Parameters.AddWithValue("@Canton", cantonUsuario);
            comando.Parameters.AddWithValue("@Distrito", distritoUsuario);
            comando.Parameters.AddWithValue("@Direccion", direccionUsuario);
            comando.Parameters.AddWithValue("@Telefono", telefonoUsuario);
            comando.Parameters.AddWithValue("@Email", correoElectronicoUsuario);
            comando.Parameters.AddWithValue("@SitioWeb", sitiowebUsuario);
            comando.Parameters.AddWithValue("@Facebook", perfilFBUsuario);
            comando.Parameters.AddWithValue("@Twitter", perfilTWUsuario);
            comando.Parameters.AddWithValue("@IG", perfilIGUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void EliminarUsuario(int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDUsuarioEliminar", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();



        }


    }


}
