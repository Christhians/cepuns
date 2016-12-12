using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class PreguntaForoViewModel 
    {
        //
        // GET: /PreguntaForoViewModel/

        public int identPreguntaForo { get; set; }
        public String tituloPreguntaForo { get; set; }
        public String descripcionPreguntaForo { get; set; }
        public DateTime? fechaPreguntaForo { get; set; }
        public int UsuarioPublicador { get; set; }
    }
}
