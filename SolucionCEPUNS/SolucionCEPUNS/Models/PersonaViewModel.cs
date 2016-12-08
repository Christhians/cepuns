using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class PersonaViewModel
    {
        //
        // GET: /PersonaViewModel/
        public int identPersona { get; set; }
        public int nroDocumento { get; set; }
        public String nombre { get; set; }
        public String paterno { get; set; }
        public String materno { get; set; }
        public String direccion { get; set; }
        public int telefono { get; set; }
        public String correo { get; set; }
        public String ptroER { get; set; }

    }
}
