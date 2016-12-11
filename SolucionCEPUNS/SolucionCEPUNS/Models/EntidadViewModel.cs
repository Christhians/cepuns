using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class EntidadViewModel
    {
        //
        // GET: /EntidadViewModel/
        public int IdentEntidad { get; set; }
        public int Modulo { get; set; }
        public String Descripcion { get; set; }
        public String URLOpcion { get; set; }
        public int EstadoRegistro { get; set; }
        public String URLImagen { get; set; }

    }
}
