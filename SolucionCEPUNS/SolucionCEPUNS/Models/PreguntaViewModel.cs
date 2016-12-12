using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class PreguntaViewModel
    {
        //
        // GET: /PreguntaViewModel/

        public int IdentPregunta { get; set; }
        public int Examen { get; set; }
        public String Descripcion { get; set; }
        public int IdentTipoPregunta { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
