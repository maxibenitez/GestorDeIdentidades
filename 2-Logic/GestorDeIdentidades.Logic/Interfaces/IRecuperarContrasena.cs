using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic.Interfaces
{
    public interface IRecuperarContrasena
    {
        bool checkPersonaPregunta(int user_id, int preg_id, string respuesta);
    }
}
