using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class PublicacionForoViewModels 
    {
        //
        // GET: /PublicacionForoViewModels/
        public int IdentPublicacionForo { get; set; }
        public int UsuarioPublico { get; set; }
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
