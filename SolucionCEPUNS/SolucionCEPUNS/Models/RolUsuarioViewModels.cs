﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class RolUsuarioViewModels 
    {
        //
        // GET: /RolUsuarioViewModels/
        public int IdentRol { get; set; }
        public int Rol { get; set; }
        public int Usuario { get; set; }
        public String Descripcion { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
