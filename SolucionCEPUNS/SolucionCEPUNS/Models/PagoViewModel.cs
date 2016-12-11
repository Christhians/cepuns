using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class PagoViewModel 
    {
        //
        // GET: /PagoViewModel/

        public int IdentPago { get; set; }
        public int Persona { get; set; }
        public int ConceptoPago { get; set; }
        public String NumeroVoucher { get; set; }
        public decimal MontoPago { get; set; }
        public DateTime? fechaPago { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
