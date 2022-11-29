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

        public List<Aplicativo> GetAplicativos()
        {
            return _aplicativosService.GetAplicativos();
        }

        public List<RolNegocio> GetRolesNegocio()
        {
            return _negocioService.GetRolesNegocio();
        }

        public bool RegistrarPersona(RegistroPersona persona)
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

                bool respuesta = _preguntasService.AddPersonaPregunta(nuevaPersonaPregunta);
                return respuesta;
            }
            else
            {
                return false;
            }
        }
    }
}
