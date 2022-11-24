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
        private PermisosService _permisos = new PermisosService();

        public List<Permiso> GetPermisos()
        {
            return _permisos.GetPermisos();
        }
    }
}
