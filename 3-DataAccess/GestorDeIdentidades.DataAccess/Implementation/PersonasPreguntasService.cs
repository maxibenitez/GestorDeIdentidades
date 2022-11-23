using Dapper;
using GestorDeIdentidades.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.DataAccess.Implementation
{
    public class PersonasPreguntasService
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public bool addPersonaPregunta(int persona, int pregunta, string respuesta)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"INSERT INTO Personas_Preguntas (user_id, preg_id, respuesta)
                                        VALUES (@User_ID, @Preg_ID, @Respuesta)";

                var parameters = new DynamicParameters();
                parameters.Add("@User_ID", persona, DbType.Int32);
                parameters.Add("@Preg_ID", pregunta, DbType.Int32);
                parameters.Add("@Respuesta", respuesta, DbType.String);

                connection.Execute(query, parameters, commandType: CommandType.Text);
                return true;
            }
        }

        public bool checkPersonaPregunta(int persona, int pregunta, string respuesta)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT COUNT(*) FROM Personas_Preguntas WHERE user_id = @User_ID AND preg_id = @Preg_ID AND respuesta = @Respuesta";

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
