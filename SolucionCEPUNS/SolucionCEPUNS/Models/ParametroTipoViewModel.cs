using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ParametroTipoViewModel 
    {

        public int IdentParametroTipo { get; set; }
        public String Descripcion { get; set; }
        public String Abreviatura { get; set; }
        public Boolean Activo { get; set; }
        public Boolean FlagEditable { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
