using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class TipoPreguntaViewModel 
    {
        //
        // GET: /TipoPreguntaViewModel/

        public int IdentTipoPregunta { get; set; }
        public int AperturaCiclo { get; set; }
        public String Descrpcion { get; set; }
        public decimal PuntajeRespuestaCorrecta { get; set; }
        public decimal PuntajeRespuestaErronea { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
