using GestorDeIdentidades.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeIdentidades.Models;
using System.Data.SqlClient;
using System.Data;

namespace GestorDeIdentidades.Logic
{
    public class LoginLogic
    {
        private PermisosService _permisosService = new PermisosService();
        private PersonasService _personasService = new PersonasService();
        private PreguntasService _preguntasService = new PreguntasService();

        public int GetPersonaId(string usuario)
        {
            return _personasService.GetPersonaId(usuario);
        }

        public List<Preguntas> GetPreguntas()
        {
            return _preguntasService.GetPreguntas();
        }

        public bool LoginPersona(int user_id, string password, out bool isAdmin)
        {
            Permiso userPermiso = _permisosService.GetPersonaPermisos(user_id);
            string userPassword = _personasService.CheckContraseña(user_id);

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(password, userPassword);

            // Se chequea si el usuario tiene rol de administrador y su estado es activo
            if(userPermiso == null)
            {
                isAdmin = false;
            }
            else if (userPermiso.Rol_neg_id == 7 && userPermiso.Estado.Equals("Activo"))
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }

            return isValidPassword;
        }

        public bool CambiarContraseña(int user_id, string nuevaCont)
        {
            string nuevaContHashed = BCrypt.Net.BCrypt.HashPassword(nuevaCont);

            return _personasService.CambiarContraseña(user_id, nuevaContHashed);
        }

        public bool CheckContraseña(int user_id, string nuevaCont)
        {
            string password = _personasService.CheckContraseña(user_id);

            return BCrypt.Net.BCrypt.Verify(nuevaCont, password);
        }

        public bool CheckPersonaPregunta(int user_id, int preg_id, string respuesta)
        {
            return _preguntasService.CheckPersonaPregunta(user_id, preg_id, respuesta);
        }
    }
}
