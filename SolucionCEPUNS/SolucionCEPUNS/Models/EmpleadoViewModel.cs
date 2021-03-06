﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class EmpleadoViewModel 
    {
        //
        // GET: /EmpleadoViewModel/

        public int IdentEmpleado { get; set; }
        public int Persona { get; set; }
        public int Usuario { get; set; }
        public String Codigo { get; set; }
        public int CargoEmpleado { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
