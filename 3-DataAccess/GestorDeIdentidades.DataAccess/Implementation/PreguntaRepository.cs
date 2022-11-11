using Dapper;
using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.DataAccess
{
    public class PreguntaRepository : IPreguntaRepository
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public List<Preguntas> GetPreguntas()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM Preguntas";

                return connection.Query<Preguntas>(query, CommandType.Text).ToList();
            }
        }
    }
}
