using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Models
{
    public class RegistroPersona
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Departamento { get; set; }

        public string Password { get; set; }

        public int Preg_id { get; set; }

        public string Pregunta { get; set; }

        public string Respuesta { get; set; }

        public int App_id { get; set; }

        public int Rol_neg_id { get; set; }

    }
}
