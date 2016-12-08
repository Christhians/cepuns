using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ResultadoViewModel 
    {
        //
        // GET: /ResultadoViewModel/

        public int identResultado { get; set; }
        public decimal PuntajeConocimiento { get; set; }
        public decimal PuntajeRazonamiento { get; set; }
        public int identExamen { get; set; }
        public int identAlumno { get; set; }

    }
}
