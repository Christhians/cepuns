using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class PagoBE
    {
        public int IdentPago { get; set; }
        public PersonaBE IdentPersona { get; set; }
        public ParametroBE ConceptoPago { get; set; }
        public String NumeroVoucher { get; set; }
        public decimal MontoPago { get; set; }
        public DateTime? fechaPago { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
