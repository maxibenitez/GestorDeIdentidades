using Dapper;
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
    public class PreguntasService
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

        public bool AddPersonaPregunta(PersonaPregunta pregunta)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"INSERT INTO Personas_Preguntas (user_id, preg_id, respuesta)
                                        VALUES (@UserId, @PregId, @Respuesta)";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", pregunta.User_id, DbType.Int32);
                parameters.Add("@PregId", pregunta.Preg_id, DbType.Int32);
                parameters.Add("@Respuesta", pregunta.Respuesta, DbType.String);

                var result = connection.Execute(query, parameters, commandType: CommandType.Text);

                if (result != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool CheckPersonaPregunta(int persona, int pregunta, string respuesta)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT COUNT(*) 
                                        FROM Personas_Preguntas 
                                        WHERE user_id = @User_ID AND preg_id = @Preg_ID AND respuesta = @Respuesta";

                var parameters = new DynamicParameters();
                parameters.Add("@User_ID", persona, DbType.Int32);
                parameters.Add("@Preg_ID", pregunta, DbType.Int32);
                parameters.Add("@Respuesta", respuesta, DbType.String);

                int cantidad = connection.Query<int>(query, parameters, commandType: CommandType.Text).FirstOrDefault();

                if (cantidad == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
