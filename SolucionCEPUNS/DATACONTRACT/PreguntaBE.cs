using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
     public class PreguntaBE
    {
        public int IdentPregunta { get; set; }
        public ExamenBE IdentExamen { get; set; }
        public String Descripcion { get; set; }        
        public TipoPreguntaBE IdentTipoPregunta { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
