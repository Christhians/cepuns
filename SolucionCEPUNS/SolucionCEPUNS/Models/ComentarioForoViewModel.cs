using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ComentarioForoViewModel 
    {
        //
        // GET: /ComentarioForoViewModel/

        public int identComentarioForo { get; set; }
        public String ComentarioForo { get; set; }
        public DateTime? FechaComentarioForo { get; set; }
        public int identPreguntaForo { get; set; }
        public int identUsuario { get; set; }
    }
}
