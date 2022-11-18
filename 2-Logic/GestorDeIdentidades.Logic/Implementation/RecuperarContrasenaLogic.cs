using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic.Implementation
{
    public class RecuperarContrasenaLogic : IRecuperarContrasena
    {
        private readonly IPersonasPreguntasService _personasPreguntasService;

        public RecuperarContrasenaLogic(IPersonasPreguntasService personasPreguntasService)
        {
            _personasPreguntasService = personasPreguntasService;
        }

        public bool checkPersonaPregunta(int user_id, int preg_id, string respuesta)
        {
            return _personasPreguntasService.checkPersonaPregunta(user_id, preg_id, respuesta);
        }
    }
}
