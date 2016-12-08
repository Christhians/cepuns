using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class AlumnoViewModel
    {
        //
        // GET: /AlumnoViewModel/

        public int identAlumno { get; set; }
        public int identPersona { get; set; }
        public String ptroTipoAlumno { get; set; }
        public int identUsuario { get; set; }
        public String ptroER { get; set; }

    }
}
