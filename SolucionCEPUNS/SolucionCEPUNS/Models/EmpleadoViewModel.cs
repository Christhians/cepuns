using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class EmpleadoViewModel 
    {
        //
        // GET: /EmpleadoViewModel/

        public int identEmpleado { get; set; }
        public int identPersona { get; set; }
        public int codigo { get; set; }
        public String ptroCargo { get; set; }
        public int identUsuario { get; set; }

    }
}
