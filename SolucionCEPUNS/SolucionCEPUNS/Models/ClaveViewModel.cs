using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ClaveViewModel 
    {
        //
        // GET: /ClaveViewModel/
        public int identClave { get; set; }
        public int identPregunta { get; set; }
        public int ClaveCorrecta { get; set; }
    }
}
