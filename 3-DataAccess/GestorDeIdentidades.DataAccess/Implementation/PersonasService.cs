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
    public class PersonasService
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public PersonaLoginInfo DatosRegistroPersona(int userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM vwDatosRegistroPersona
                                        WHERE user_id = @UserId";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", userId, DbType.Int32);

                return connection.Query<PersonaLoginInfo>(query, parameters, commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public int AddPersona(Persona persona)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"INSERT INTO Personas (nombres, apellidos, direccion, ciudad, departamento, hashpwd)
                                        VALUES (@Nombres, @Apellidos, @Direccion, @Ciudad, @Departamento, @Hashpwd)";

                var parameters = new DynamicParameters();
                parameters.Add("@Nombres", persona.Nombres, DbType.String);
                parameters.Add("@Apellidos", persona.Apellidos, DbType.String);
                parameters.Add("@Direccion", persona.Direccion, DbType.String);
                parameters.Add("@Ciudad", persona.Ciudad, DbType.String);
                parameters.Add("@Departamento", persona.Departamento, DbType.String);
                parameters.Add("@Hashpwd", persona.Password, DbType.Binary);

                connection.Execute(query, parameters, commandType: CommandType.Text);

                const string query2 = @"SELECT SCOPE_IDENTITY()";

                int lastId = connection.Query<int>(query2, CommandType.Text).First();

                return lastId;
            }
        }
    }
}
