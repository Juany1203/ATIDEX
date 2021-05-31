using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaComun.Cache;



namespace CapaDeDatos
{
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
                            UserLoginCache.TipoUsuario = reader.GetBoolean(2);
                            UserLoginCache.NombreUsuario = reader.GetString(3);
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
                            UserLoginCache.perfiligUsuario= reader.GetString(15);

                        }

                        return true;
                    }
                    else
                        return false;

                }


            }

        }
    }
}
