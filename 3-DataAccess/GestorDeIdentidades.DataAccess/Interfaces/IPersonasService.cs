using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.DataAccess.Interfaces
{
    public interface IPersonasService
    {
        PersonaLoginInfo DatosRegistroPersona(int userId);

        RolNegocioPersona GetRolNegPersona(int userId);

        int AddPersona(Persona persona);
    }
}
