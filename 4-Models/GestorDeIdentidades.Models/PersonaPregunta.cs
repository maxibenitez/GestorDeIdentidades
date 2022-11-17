using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Models
{
    public class PersonaPregunta
    {
        public int User_id { get; set; }

        public int Preg_id { get; set; }

        public string Respuesta { get; set; }
    }
}
