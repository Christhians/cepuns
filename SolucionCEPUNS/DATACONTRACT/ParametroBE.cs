using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class ParametroBE
    {
        public int identParametro { get; set; }
        public String descripcion { get; set; }
        public ParametroTipoBE identParametroTipo { get; set; }
        public String abreviatura { get; set; }
        public Boolean acitvo { get; set; }
    }
}
