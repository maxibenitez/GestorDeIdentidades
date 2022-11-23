using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.DataAccess.Interfaces
{
    public interface IPreguntasService
    {
        List<Preguntas> GetPreguntas();

        bool AddPersonaPregunta(PersonaPregunta pregunta);
    }
}
