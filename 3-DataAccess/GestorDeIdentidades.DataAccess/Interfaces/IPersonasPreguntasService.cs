using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.DataAccess.Interfaces
{
    public interface IPersonasPreguntasService
    {
        bool addPersonaPregunta(int persona,int pregunta,string respuesta);

        bool checkPersonaPregunta(int persona, int pregunta, string respuesta);
    }
}
