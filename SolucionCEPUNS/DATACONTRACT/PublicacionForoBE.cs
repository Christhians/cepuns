using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class PublicacionForo
    {
        public int IdentPublicacionForo { get; set; }
        public UsuarioBE UsuarioPublico { get; set; }
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
