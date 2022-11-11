using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Logic.Interfaces;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class PreguntaLogic : IPreguntaLogic
    {
        private readonly IPreguntaRepository _preguntaRepository;

        //private PreguntaRepository _preguntas = new PreguntaRepository();

        public PreguntaLogic(IPreguntaRepository preguntaRepository)
        {
            _preguntaRepository = preguntaRepository;
        }

        public List<Preguntas> GetPreguntas()
        {
            return _preguntaRepository.GetPreguntas();
        }

        //public List<Preguntas> GetPreguntas()
        //{
        //    return _preguntas.GetPreguntas();
        //}
    }
}
