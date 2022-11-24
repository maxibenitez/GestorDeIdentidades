using GestorDeIdentidades.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class RecuperarContrasenaLogic
    {
        private readonly PersonasPreguntasService _personasPreguntasService = new PersonasPreguntasService();

        public bool checkPersonaPregunta(int user_id, int preg_id, string respuesta)
        {
            return _personasPreguntasService.checkPersonaPregunta(user_id, preg_id, respuesta);
        }
    }
}
