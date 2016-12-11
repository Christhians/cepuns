using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
  public   class ComentarioForoBE
    {
        public int IdentComentarioForo { get; set; }       
        public UsuarioBE UsuarioComenta { get; set; }
        public PublicacionForoBE Publicacion { get; set; }
        public String Comentario { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
