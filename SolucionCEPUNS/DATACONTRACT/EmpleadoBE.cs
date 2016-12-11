using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class EmpleadoBE
    {
        public int IdentEmpleado { get; set; }
        public PersonaBE IdentPersona { get; set; }        
        public UsuarioBE identUsuario { get; set; }
        public String Codigo { get; set; }
        public ParametroBE CargoEmpleado { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
