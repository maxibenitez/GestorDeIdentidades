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

        private PreguntasService _preguntas = new PreguntasService();

        public List<Preguntas> GetPreguntas()
        {
            return _preguntas.GetPreguntas();
        }
    }
}
