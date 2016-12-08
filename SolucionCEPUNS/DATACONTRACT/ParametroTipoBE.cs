using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class ParametroTipoBE
    {
        public int identParametroTipo {  get; set; }
        public String descripcion { get; set; }
        public String abreviatura { get; set; }
        public Boolean activo { get; set; }
        public Boolean flagEditable { get; set; }
    }
}
