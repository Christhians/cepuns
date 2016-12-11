using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class DoncenteCursoBE
    {
        public int IdentDocenteCurso{ get; set; }
        public DocenteBE Docente { get; set; }
        public int IdentCurso { get; set; }
        public DocenteBE AperturaCurso { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
