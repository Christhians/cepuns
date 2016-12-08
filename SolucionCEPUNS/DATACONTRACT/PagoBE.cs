using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class PagoBE
    {
        public int identPagos{ get; set; }
        public String ConceptoPago { get; set; }
        public String NumeroVoucher { get; set; }
        public decimal MontoPago { get; set; }
        public DateTime? fechaPago { get; set; }
        public PersonaBE identPersona{ get; set; }
    }
}
