using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class EntidadBE
    { 
        public int IdentEntidad { get; set; }
        public ModuloBE IdentModulo { get; set; }
        public String Descripcion { get; set; }
        public String URLOpcion { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public String URLImagen { get; set; }

    }
}
