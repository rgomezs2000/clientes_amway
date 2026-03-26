using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clientes_amway.Properties;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace clientes_amway
{
    class UsuarioDAO
    {
        public static Usuario ValidarUsuario(string login)
        {
            Usuario usuario = new Usuario();
            MySqlConnection conn = new MySqlConnection(Settings.Default.clientes_amwayConnectionString);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                cmd.CommandText = "CALL validar_usuarios('" + login + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        usuario.IdUsuario = int.Parse(reader["id_usuarios"].ToString());
                        usuario.NombreUsuario = reader["nombre_usuarios"].ToString();
                        usuario.LoginUsuario = reader["login_usuarios"].ToString();
                        usuario.ClaveUsuario = reader["clave_usuario"].ToString();
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return usuario;
        }

        public static int ContarUsuario(string login)
        {
            int existe = 0;
            MySqlConnection conn = new MySqlConnection(Settings.Default.clientes_amwayConnectionString);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                cmd.CommandText = "CALL contar_usuarios('" + login + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        existe = int.Parse(reader["cantidad"].ToString());
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return existe;
        }
    }
}
