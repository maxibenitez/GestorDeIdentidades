using GestorDeIdentidades.DataAccess.Implementation;
using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestorDeIdentidades.Logic.Implementation
{
    public class CambiarContraseņa
    {
        private readonly PersonasService personas = new PersonasService();

        public bool CambiarContraseņa(int user_id, string nuevaCont)
        {
            var nuevaContHashed = BCrypt.Net.BCrypt.HashPassword(nuevaCont);

            return personas.cambiarContraseņa(int user_id, string nuevaContHashed);
        }
    }
}