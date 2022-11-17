using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic.Interfaces
{
    public interface IRegistroLogic
    {
        List<Preguntas> GetPreguntas();

        List<Aplicativos> GetAplicativos();

        List<RolNegocio> GetRolesNegocio();

        int RegistrarPersona(RegistroPersona persona);
    }
}
