﻿using GestorDeIdentidades.DataAccess.Interfaces;
using GestorDeIdentidades.Logic.Interfaces;
using GestorDeIdentidades.Models;
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

        public bool GestionarPermisos(List<Permiso> permisos)
        {
            List<PermisoPendiente> permisosPendientes = _permisosService.GetPermisosPendientes();

            foreach(Permiso permiso in permisos)
            {
                _permisosService.UpdatePersonaPermiso(permiso);
                permisos.Remove(permiso);
            }

            if(permisos.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
