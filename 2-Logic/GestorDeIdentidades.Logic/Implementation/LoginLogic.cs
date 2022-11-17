using GestorDeIdentidades.DataAccess.Implementation;
using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeIdentidades.Models;

namespace GestorDeIdentidades.Logic.Implementation
{
    public class LoginLogic : ILoginLogic
    {
        private readonly IPersonasService _personasService;
        private readonly IPreguntasService _preguntasService;

        public LoginLogic(IPersonasService personasService, IPreguntasService preguntasService)
        {
            _personasService = personasService;
            _preguntasService = preguntasService;
        }

        public bool LoginPersona(int userId, string password, out bool isAdmin)
        {
            PersonaLoginInfo userSession = _personasService.DatosRegistroPersona(userId);
            RolNegocioPersona rolPersona = _personasService.GetRolNegPersona(userId);

            bool isValidPassword = false;

            if(userSession != null)
            {
                isValidPassword = BCrypt.Net.BCrypt.Verify(password, userSession.Password);
            }

            if(rolPersona.DescripcionRolNeg.Equals("Gestionar usuarios"))
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
