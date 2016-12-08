using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ParametroTipoViewModel 
    {

        public int identParametroTipo { get; set; }
        public String descripcion { get; set; }
        public String abreviatura { get; set; }
        public Boolean activo { get; set; }
        public Boolean flagEditable { get; set; }

    }
}
