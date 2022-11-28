using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Models
{
    public class Permiso
    {
        public int User_id { get; set; }

        public string NombrePersona { get; set; }

        public int App_id { get; set; }

        public string NombreApp { get; set; }

        public int Rol_neg_id { get; set; }

        public string Descripcion_rol_neg{ get; set; }

        public DateTime Fecha_solicitud { get; set; }

        public DateTime? Fecha_autorizacion { get; set; }

        public string Estado { get; set; }
    }
}
