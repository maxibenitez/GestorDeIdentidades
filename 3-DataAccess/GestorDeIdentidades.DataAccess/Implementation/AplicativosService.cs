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
using GestorDeIdentidades.DataAccess.Interfaces;

namespace GestorDeIdentidades.DataAccess
{
    public class AplicativosService : IAplicativosService
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public List<Aplicativos> GetAplicativos()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM Aplicativos";

                return connection.Query<Aplicativos>(query, CommandType.Text).ToList();
            }
        }
    }
}