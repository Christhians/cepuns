using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class ParametroTipoBE
    {
        public int IdentParametroTipo {  get; set; }
        public String Descripcion { get; set; }
        public String Abreviatura { get; set; }
        public Boolean Activo { get; set; }
        public Boolean FlagEditable { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
