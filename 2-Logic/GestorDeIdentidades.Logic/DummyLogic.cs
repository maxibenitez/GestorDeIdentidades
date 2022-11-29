using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeIdentidades.DataAccess;

namespace GestorDeIdentidades.Logic
{
    public class DummyLogic
    {
        private PermisosService _permisosService = new PermisosService();
        private AplicativosService _aplicativosService = new AplicativosService();

        public List<Permiso> GetPersonaPermisosActivos(int userId)
        {
            List<Permiso> permisos = _permisosService.GetPersonaPermisosActivos(userId);

            return permisos;
        }

        public List<Aplicativo> GetAplicativosDummy(int user_id)
        {
            return _aplicativosService.GetAplicativosDummy(user_id);
        }

        public List<Menus> GetMenuDummy(int user_id, int app_id)
        {
            return _aplicativosService.GetMenuDummy(user_id, app_id);
        }
    }
}
