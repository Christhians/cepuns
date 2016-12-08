using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public  class RespuestaAlumno
    {
        public int identRespuestaAlumno { get; set; }
        public PreguntaBE identPregunta { get; set; }
        public ParametroBE ClaveMarcada { get; set; }
         
    }
}
