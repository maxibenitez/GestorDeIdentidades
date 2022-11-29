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
    public class PermisosService
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public List<Permiso> GetPermisos()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM vwPermisos";

                return connection.Query<Permiso>(query, CommandType.Text).ToList();
            }
        }

        public Permiso GetPersonaPermisos(int userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM vwPermisos
                                        WHERE user_id = @UserId";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", userId, DbType.Int32);

                return connection.Query<Permiso>(query, parameters, commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public List<Permiso> GetPermisosPendientes()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM vwPermisos
                                        WHERE estado = 'Pendiente'";

                return connection.Query<Permiso>(query, CommandType.Text).ToList();
            }
        }

        public List<Permiso> GetPermisosActivos()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM vwPermisos
                                        WHERE estado = 'Activo'";

                return connection.Query<Permiso>(query, CommandType.Text).ToList();
            }
        }

        public List<Permiso> GetPermisosDenegados()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM vwPermisos
                                        WHERE estado = 'Denegado'";

                return connection.Query<Permiso>(query, CommandType.Text).ToList();
            }
        }

        public List<Permiso> GetPersonaPermisosActivos(int userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT rol_neg_id, estado FROM vwAppDummy 
                                        WHERE user_id = @UserId, estado = 'Activo' ";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", userId, DbType.Int32);

                return connection.Query<Permiso>(query, CommandType.Text).ToList();
            }
        }

        public bool AddPersonaPermiso(Permiso permiso)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"INSERT INTO Permisos (user_id, app_id, rol_neg_id, fecha_solicitud, fecha_autorizacion, estado)
                                        VALUES (@UserId, @AppId, @RolNegId, @FechaSolicitud, @FechaAutorizacion, @Estado)";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", permiso.User_id, DbType.Int32);
                parameters.Add("@AppId", permiso.App_id, DbType.Int32);
                parameters.Add("@RolNegId", permiso.Rol_neg_id, DbType.Int32);
                parameters.Add("@FechaSolicitud", permiso.Fecha_solicitud, DbType.Date);
                parameters.Add("@FechaAutorizacion", permiso.Fecha_autorizacion, DbType.Date);
                parameters.Add("@Estado", permiso.Estado, DbType.String);

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

        public bool EditarPermiso(int userId, string estado)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"UPDATE Permisos
                                        SET fecha_autorizacion = @FechaAutorizacion, estado = @Estado
                                        WHERE user_id = @UserId";

                var parameters = new DynamicParameters();
                parameters.Add("@UserId", userId, DbType.Int32);
                parameters.Add("@FechaAutorizacion", DateTime.Now, DbType.Date);
                parameters.Add("@Estado", estado, DbType.String);

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
    }
}
