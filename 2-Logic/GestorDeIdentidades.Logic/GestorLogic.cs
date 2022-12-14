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
        private AplicativosService _aplicativosService = new AplicativosService();
        private NegocioService _negocioService = new NegocioService();

        public List<Permiso> GetPermisos()
        {
            List<Permiso> permisos = _permisosService.GetPermisos();

            return permisos;
        }

        public List<Aplicativo> GetAplicativos()
        {
            List<Aplicativo> aplicativos = _aplicativosService.GetAplicativos();

            return aplicativos;
        }

        public List<RolAplicativo> GetRolesAplicativos()
        {
            List<RolAplicativo> rolesAplicativos = _aplicativosService.GetRolesAplicativos();

            return rolesAplicativos;
        }

        public List<RolNegocio> GetRolesNegocio()
        {
            List<RolNegocio> rolesNegocio = _negocioService.GetRolesNegocio();

            return rolesNegocio;
        }

        public List<RolNegocioAplicativo> GetRolesNegocioAplicativos()
        {
            List<RolNegocioAplicativo> rolesNegocioAplicativo = _negocioService.GetRolesNegocioAplicativos();

            return rolesNegocioAplicativo;
        }

        public bool EditarPermiso(int userId,int app_id, string estado)
        {
            bool result = _permisosService.EditarPermiso(userId, app_id, estado);

            return result;
        }

        public List<int> GetRolesNegocioAplicativos(int rol_neg_id, int app_id)
        {
            return _aplicativosService.GetRolesNegocioAplicativos(rol_neg_id, app_id);
        }

        public void EditarAplicativos(int rol_neg_id, int app_id, List<int> rolesId)
        {
            _aplicativosService.BorrarRolesNegocioAplicativos(rol_neg_id, app_id);

            foreach (int rol in rolesId)
            {
                _aplicativosService.AgregarRolesNegocioAplicativos(rol_neg_id, app_id, rol);
            }      
        }
    }
}
