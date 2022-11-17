using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic.Implementation
{
    public class GestorLogic : IGestorLogic
    {
        private readonly IPermisosService _permisosService;

        public GestorLogic(IPermisosService permisosService)
        {
            _permisosService = permisosService;
        }
    }
}
