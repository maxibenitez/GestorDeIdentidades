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
        private PermisosService _permisosService = new PermisosService();

        public List<Permiso> GetPermisos()
        {
            return _permisosService.GetPermisos();
        }

        public List<Permiso> GetPermisosActivos()
        {
            return _permisosService.GetPermisosActivos();
        }

        public List<Permiso> GetPermisosDenegados()
        {
            return _permisosService.GetPermisosDenegados();
        }

        public List<Permiso> GetPermisosPendientes()
        {
            return _permisosService.GetPermisosPendientes();
        }

        public bool SolicitarPermiso(int user_id, int app_id, int rol_neg_id)
        {
            var nuevoPermiso = new Permiso()
            {
                User_id = user_id,
                App_id = app_id,
                Rol_neg_id = rol_neg_id,
                Fecha_solicitud = DateTime.Now,
                Fecha_autorizacion = null,
                Estado = "Pendiente"
            };

            bool respuesta = _permisosService.AddPersonaPermiso(nuevoPermiso);
            return respuesta;
        }

        public bool EditarPermiso(int userId, string estado)
        {
            return _permisosService.EditarPermiso(userId, estado);
        }
    }
}
