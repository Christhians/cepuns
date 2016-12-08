using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public  class ClaveBE
    {
        public int identClave{ get; set; }
        public PreguntaBE identPregunta { get; set; }
        public ParametroBE ClaveCorrecta { get; set; }
    }
}
