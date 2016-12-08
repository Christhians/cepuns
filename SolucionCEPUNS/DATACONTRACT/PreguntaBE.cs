using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
     public class PreguntaBE
    {
        public int identPregunta { get; set; }
        public String descripcion { get; set; }
        public ExamenBE identExamen { get; set; }
        public TipoPreguntaBE identTipoPregunta { get; set; }

    }
}
