using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class EmpleadoBE
    {
        public int identEmpleado { get; set; }
        public PersonaBE identPersona { get; set; }
        public int codigo { get; set; }
        public String ptroCargo { get; set; }
        public UsuarioBE identUsuario { get; set; }
    }
}
