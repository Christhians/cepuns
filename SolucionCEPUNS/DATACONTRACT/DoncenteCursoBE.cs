using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class DoncenteCursoBE
    {
        public int identDocenteCurso{ get; set; }
        public int identDocente { get; set; }
        public int identCurso { get; set; }
        public DocenteBE identAperturaCurso { get; set; }
    }
}
