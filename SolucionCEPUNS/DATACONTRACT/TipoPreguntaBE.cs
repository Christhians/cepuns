using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class TipoPreguntaBE
    {
        public int identTipoPregunta { get; set; }
        public String descrpcion { get; set; }
        public int puntaje { get; set; }
        public AperturaCicloBE identAperturaCiclo { get; set; }
    }
}
