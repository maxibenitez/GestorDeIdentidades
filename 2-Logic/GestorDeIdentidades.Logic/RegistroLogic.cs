using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class RegistroLogic
    {
        private PermisosService _permisosService = new PermisosService();
        private AplicativosService _aplicativosService = new AplicativosService();
        private NegocioService _negocioService = new NegocioService();
        private PersonasService _personasService = new PersonasService();
        private PreguntasService _preguntasService = new PreguntasService();

        public List<Preguntas> GetPreguntas()
        {
            return _preguntasService.GetPreguntas();
        }

        public List<Aplicativos> GetAplicativos()
        {
            return _aplicativosService.GetAplicativos();
        }

        public List<RolNegocio> GetRolesNegocio()
        {
            return _negocioService.GetRolesNegocio();
        }

        public int RegistrarPersona(RegistroPersona persona)
        {
            // Ingresa nueva persona
            var hashpwd = BCrypt.Net.BCrypt.HashPassword(persona.Password);

            var nuevaPersona = new Persona()
            {
                Nombres = persona.Nombres,
                Apellidos = persona.Apellidos,
                Direccion = persona.Direccion,
                Ciudad = persona.Ciudad,
                Departamento = persona.Departamento,
                Password = hashpwd
            };

            int newUserId = _personasService.AddPersona(nuevaPersona);

            if(newUserId != null)
            {
                // Ingresa pregunta y respuesta de nueva persona
                var nuevaPersonaPregunta = new PersonaPregunta()
                {
                    User_id = newUserId,
                    Preg_id = persona.Preg_id,
                    Respuesta = persona.Respuesta
                };

                _preguntasService.AddPersonaPregunta(nuevaPersonaPregunta);

                // Ingresa solicitud de permisos de nueva persona
                var nuevoPermiso = new Permiso()
                {
                    User_id = newUserId,
                    App_id = persona.App_id,
                    Rol_neg_id = persona.Rol_neg_id,
                    Fecha_solicitud = DateTime.Now,
                    Fecha_autorizacion = null,
                    Estado = "Pendiente"
                };

                _permisosService.AddPersonaPermiso(nuevoPermiso);
            }

            return newUserId;
        }
    }
}
