using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GestorDeIdentidades.DataAccess
{
    public class PersonasRepository
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public int VerificarUsuario(string usuario)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"SELECT * FROM Personas WHERE user_id = " + usuario;

                return connection.Query<Persona>(query, CommandType.Text).Count();
            }
        }

        public bool RegistrarUsuario(int usuario, string nombres, string apellidos, string direccion, string ciudad, string departamento, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Personas VALUES (" + nombres+", "+apellidos+", "+direccion+", "+ciudad+", "+departamento+", "+password+")";

                connection.Query(query, CommandType.Text);
            }
                return true;
        }
    }
}