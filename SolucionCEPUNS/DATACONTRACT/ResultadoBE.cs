using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public class ResultadoBE
    {
        public int identResultado { get; set; }
        public decimal PuntajeConocimiento { get; set; }
            public decimal PuntajeRazonamiento { get; set; }
        public ExamenBE identExamen { get; set; }
        public AlumnoBE identAlumno { get; set; }

    }
}
