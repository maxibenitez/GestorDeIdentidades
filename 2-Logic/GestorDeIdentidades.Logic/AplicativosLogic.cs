using GestorDeIdentidades.DataAccess;
using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic
{
    public class AplicativosLogic
    {
        private AplicativosRepository _aplicativos = new AplicativosRepository();

        public List<Aplicativos> GetAplicativos()
        {
            return _aplicativos.GetAplicativos();
        }
    }
}
