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

namespace GestorDeIdentidades.DataAccess.Implementation
{
    public class NegocioService
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public List<RolNegocio> GetRolesNegocio()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM Roles_Negocio";

                return connection.Query<RolNegocio>(query, CommandType.Text).ToList();
            }
        }
    }
}
