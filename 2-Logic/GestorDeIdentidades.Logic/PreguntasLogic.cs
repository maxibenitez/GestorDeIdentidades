using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class PreguntasLogic
    {

        private PreguntasService _preguntasService = new PreguntasService();

        public List<Preguntas> GetPreguntas()
        {
            return _preguntasService.GetPreguntas();
        }
    }
}
