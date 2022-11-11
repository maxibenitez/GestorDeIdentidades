using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class PermisosLogic
    {
        private PermisosRepository _permisos = new PermisosRepository();

        public List<Permiso> GetPermisos()
        {
            return _permisos.GetPermisos();
        }
    }
}
