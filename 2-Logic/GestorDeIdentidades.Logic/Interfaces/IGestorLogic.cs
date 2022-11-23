﻿using GestorDeIdentidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeIdentidades.Logic.Interfaces
{
    public interface IGestorLogic
    {
        bool GestionarPermisos(List<Permiso> permisos);
    }
}
