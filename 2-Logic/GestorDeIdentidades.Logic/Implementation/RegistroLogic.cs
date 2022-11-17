using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Logic.Interfaces;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic.Implementation
{
    public class RegistroLogic : IRegistroLogic
    {
        private readonly IPersonasService _personasService;
        private readonly IPermisosService _permisosService;
        private readonly IPreguntasService _preguntasService;
        private readonly IAplicativosService _aplicativosService;
        private readonly INegocioService _negocioService;

        public RegistroLogic(IPersonasService personasService, 
                            IPermisosService permisosService, 
                            IPreguntasService preguntasService, 
                            IAplicativosService aplicativosService, 
                            INegocioService negocioService)
        {
            _personasService = personasService;
            _permisosService = permisosService;
            _preguntasService = preguntasService;
            _aplicativosService = aplicativosService;
            _negocioService = negocioService;
        }

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
