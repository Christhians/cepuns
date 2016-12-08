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

        public int identPagos { get; set; }
        public String ConceptoPago { get; set; }
        public String NumeroVoucher { get; set; }
        public decimal MontoPago { get; set; }
        public DateTime? fechaPago { get; set; }
        public int identPersona { get; set; }

    }
}
