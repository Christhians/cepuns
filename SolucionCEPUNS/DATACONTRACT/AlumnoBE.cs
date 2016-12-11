using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class AlumnoBE
    {
        public int IdentAlumno { get; set;}
        public PersonaBE Persona { get; set; }
        public UsuarioBE IdentUsuario { get; set; }
        public String Codigo { get; set; }
        public ParametroBE TipoAlumno { get; set; }        
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set;}
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificador { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
