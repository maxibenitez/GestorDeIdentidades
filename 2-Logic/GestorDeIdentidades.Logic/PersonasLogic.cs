using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class PersonasLogic
    {
        private PersonasRepository _personas = new PersonasRepository();

        public bool ValidarUsuario(string usuario)
        {
            if (_personas.VerificarUsuario(usuario) == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RegistrarUsuario(int usuario, string nombres, string apellidos, string direccion, string ciudad, string departamento, string password)
        {
            _personas.RegistrarUsuario(usuario, nombres, apellidos, direccion, ciudad,departamento, password);
            return true;
        }
    }
}