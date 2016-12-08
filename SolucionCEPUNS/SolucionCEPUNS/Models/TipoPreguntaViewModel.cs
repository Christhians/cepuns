using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class TipoPreguntaViewModel 
    {
        //
        // GET: /TipoPreguntaViewModel/

        public int identTipoPregunta { get; set; }
        public String descrpcion { get; set; }
        public int puntaje { get; set; }
        public int identAperturaCiclo { get; set; }

    }
}
