using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class PreguntaViewModel
    {
        //
        // GET: /PreguntaViewModel/

        public int identPregunta { get; set; }
        public String descripcion { get; set; }
        public int identExamen { get; set; }
        public int identTipoPregunta { get; set; }

    }
}
