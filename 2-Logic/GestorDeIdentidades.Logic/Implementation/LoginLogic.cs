using GestorDeIdentidades.DataAccess.Implementation;
using GestorDeIdentidades.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeIdentidades.Models;

namespace GestorDeIdentidades.Logic.Implementation
{
    public class LoginLogic
    {
        private PermisosService _permisosService = new PermisosService();
        private PersonasService _personasService = new PersonasService();
        private PreguntasService _preguntasService = new PreguntasService();

        public bool LoginPersona(int userId, string password, out bool isAdmin)
        {
            PersonaLoginInfo userSession = _personasService.DatosRegistroPersona(userId);
            Permiso userPermiso = _permisosService.GetPersonaPermisos(userId);

            bool isValidPassword = false;

            // Si existe un usuario con ese ID, se chequea la contraseña
            if (userSession != null)
            {
                isValidPassword = BCrypt.Net.BCrypt.Verify(password, userSession.Password);
            }

            // Se chequea si el usuario tiene rol de administrador y su estado es activo
            if (userPermiso.Rol_neg_id == 12 && userPermiso.Estado.Equals("Activo"))
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }

            return isValidPassword;
        }

        public bool NuevoPassword(string password)
        {
            throw new NotImplementedException();
        }

        public string RecuperarPassword(string respuesta)
        {
            throw new NotImplementedException();
        }
    }
}
