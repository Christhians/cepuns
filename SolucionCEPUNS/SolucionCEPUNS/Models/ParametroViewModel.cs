using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ParametroViewModel 
    {
        //
        // GET: /ParametroViewModel/

        public int identParametro { get; set; }
        public String descripcion { get; set; }
        public int identParametroTipo { get; set; }
        public String abreviatura { get; set; }
        public Boolean acitvo { get; set; }
    }
}
