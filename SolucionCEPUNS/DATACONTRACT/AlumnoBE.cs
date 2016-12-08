using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class AlumnoBE
    {
        public int identAlumno { get; set;}
        public PersonaBE identPersona { get; set; }
        public String ptroTipoAlumno { get; set; }
        public UsuarioBE identUsuario { get; set; }
        public String ptroER { get; set; }

    }
}
