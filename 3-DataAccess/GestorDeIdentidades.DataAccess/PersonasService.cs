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
using System.Security.Cryptography;
using System.Collections;
using System.Security;

namespace GestorDeIdentidades.DataAccess
{
    public class PersonasService
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public int GetPersonaId(string usuario)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT user_id FROM Personas
                                        WHERE nombres = @Nombres AND apellidos = @Apellidos";

                string[] persona = usuario.Split(' ');
                
                if (persona.Length > 1)
                {
                    string nombres = persona[0];
                    string apellidos = persona[1];

                    var parameters = new DynamicParameters();
                    parameters.Add("@Nombres", nombres, DbType.String);
                    parameters.Add("@Apellidos", apellidos, DbType.String);

                    return connection.Query<int>(query, parameters, commandType: CommandType.Text).FirstOrDefault();
                }
                else
                {
                    return 0;
                }
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
                parameters.Add("@Hashpwd", persona.Password, DbType.String);

                connection.Execute(query, parameters, commandType: CommandType.Text);

                const string query2 = @"SELECT TOP 1 user_id FROM Personas
                                        ORDER BY user_id DESC";

                return connection.Query<int>(query2, CommandType.Text).FirstOrDefault();
            }
        }

        public bool CambiarContraseña(int user_id, string nuevaContHashed)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"UPDATE Personas 
                                        SET hashpwd = @nuevaContHashed 
                                        WHERE user_id = @user_id";

                var parameters = new DynamicParameters();
                parameters.Add("@nuevaContHashed", nuevaContHashed, DbType.String);
                parameters.Add("@user_id", user_id, DbType.Int32);

                var resp = connection.Execute(query, parameters, commandType: CommandType.Text);

                if(resp != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string CheckContraseña(int user_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT hashpwd FROM Personas
                                        WHERE user_id = @UserId";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", user_id, DbType.Int32);

                return connection.Query<string>(query, parameters, commandType: CommandType.Text).FirstOrDefault();
            }
        }
    }
}
