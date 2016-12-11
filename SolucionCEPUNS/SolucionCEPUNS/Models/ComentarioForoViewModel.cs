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

        public int IdentComentarioForo { get; set; }
        public int UsuarioComenta { get; set; }
        public int Publicacion { get; set; }
        public String Comentario { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
