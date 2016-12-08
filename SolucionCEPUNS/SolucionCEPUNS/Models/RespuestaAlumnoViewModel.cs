using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class RespuestaAlumnoViewModel
    {
        //
        // GET: /RespuestaAlumnoViewModel/

        public int identRespuestaAlumno { get; set; }
        public int identPregunta { get; set; }
        public int ClaveMarcada { get; set; }


    }
}
