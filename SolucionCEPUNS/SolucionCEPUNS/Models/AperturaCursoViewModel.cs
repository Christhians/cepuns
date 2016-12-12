using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class AperturaCursoViewModel 
    {
        //
        // GET: /AperturaCursoViewModel/
        public int IdentAperturaCurso { get; set; }
        public int Curso { get; set; }
        public int Ciclo { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
