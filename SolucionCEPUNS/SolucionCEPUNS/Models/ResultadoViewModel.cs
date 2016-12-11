using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ResultadoViewModel 
    {
        //
        // GET: /ResultadoViewModel/

        public int IdentResultado { get; set; }
        public int Examen { get; set; }
        public int Alumno { get; set; }
        public decimal PuntajeConocimiento { get; set; }
        public decimal PuntajeRazonamiento { get; set; }
        public decimal PuntajeTotal { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
