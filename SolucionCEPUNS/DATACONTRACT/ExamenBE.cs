using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public  class ExamenBE
    {
        public int identExamen { get; set; }
        public String nombreEXAMEN { get; set; }
        public DateTime? fechaExamen { get; set; }
        public AperturaCicloBE identAperturaCiclo { get; set; }

        public GrupoBE identGrupo { get; set; }
    }
}
