using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ExamenViewModel 
    {
        //
        // GET: /ExamenViewModel/
        public int identExamen { get; set; }
        public String nombreEXAMEN { get; set; }
        public DateTime? fechaExamen { get; set; }
        public int identAperturaCiclo { get; set; }

        public int identGrupo { get; set; }

    }
}
