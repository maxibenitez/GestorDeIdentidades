using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class GestorLogic
    {
        private PermisosService _permisosService = new PermisosService();

        public List<Permiso> GetPermisos()
        {
            List<Permiso> permisos = _permisosService.GetPermisos();

            return permisos;
        }

        public bool EditarPermiso(int userId, string estado)
        {
            bool result = _permisosService.EditarPermiso(userId, estado);

            return result;
        }
    }
}
