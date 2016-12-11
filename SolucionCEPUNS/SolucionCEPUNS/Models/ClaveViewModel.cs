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
        public int IdentClave { get; set; }
        public int Pregunta { get; set; }
        public int ClaveCorrecta { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
