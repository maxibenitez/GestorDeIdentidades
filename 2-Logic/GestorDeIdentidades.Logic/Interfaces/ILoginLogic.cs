using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic.Interfaces
{
    public interface ILoginLogic
    {
        bool LoginPersona(int userId, string password);

        bool NuevoPassword(string password);

        string RecuperarPassword(string respuesta);
    }
}
