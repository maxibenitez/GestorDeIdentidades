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
    public class AplicativosService
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GestorDeIdentidades"].ToString();

        public List<Aplicativo> GetAplicativos()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM Aplicativos";

                return connection.Query<Aplicativo>(query, CommandType.Text).ToList();
            }
        }

        public List<RolAplicativo> GetRolesAplicativos()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT * FROM Roles_Aplicativos";

                return connection.Query<RolAplicativo>(query, CommandType.Text).ToList();
            }
        }

        public bool AgregarRolesNegocioAplicativos(int rol_neg_id, int app_id, int rol_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @" INSERT INTO Roles_Negocio_Aplicativos(rol_neg_id, app_id, rol_id)
                                        VALUES (@Rol_neg_id, @App_id, @Rol_id)";

                var parameters = new DynamicParameters();
                parameters.Add("@Rol_neg_id", rol_neg_id, DbType.Int32);
                parameters.Add("@App_id", app_id, DbType.Int32);
                parameters.Add("@Rol_id", rol_id, DbType.Int32);

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

        public List<Aplicativo> GetAplicativosDummy(int user_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT app_id, nombreapp FROM vwAppDummy
                                         WHERE user_id = @User_id AND estado = 'Activo'";

                var parameters = new DynamicParameters();
                parameters.Add("@User_id", user_id, DbType.Int32);

                return connection.Query<Aplicativo>(query, parameters, commandType: CommandType.Text).ToList();
            }
        }
        public List<Menus> GetMenuDummy(int user_id, int app_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"SELECT menu_id, descripcion_menu FROM vwAppDummy
                                         WHERE user_id = @User_id AND app_id = @App_id";

                var parameters = new DynamicParameters();
                parameters.Add("@User_id", user_id, DbType.Int32);
                parameters.Add("@App_id", app_id, DbType.Int32);

                return connection.Query<Menus>(query, parameters, commandType: CommandType.Text).ToList();
            }
        }


        public bool BorrarRolesNegocioAplicativos(int rol_neg_id, int app_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = @"DELETE FROM Roles_Negocio_Aplicativos
                                        WHERE rol_neg_id = @Rol_neg_id AND app_id = @Aplicativo_id";

                var parameters = new DynamicParameters();
                parameters.Add("@Rol_neg_id", rol_neg_id, DbType.Int32);
                parameters.Add("@Aplicativo_id", app_id, DbType.Int32);

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

        //public List<Aplicativo> GetMenuAutorizado()
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();

        //        const string query = "@SELECT nombreapp FROM vwAppDummy";

        //        return connection.Query<Aplicativo>(query, CommandType.Text).ToList();
        //    }
        //}
    }
}