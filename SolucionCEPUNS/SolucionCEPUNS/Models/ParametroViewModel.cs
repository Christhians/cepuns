using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ParametroViewModel 
    {
        //
        // GET: /ParametroViewModel/

        public int IdentParametro { get; set; }
        public String Descripcion { get; set; }
        public int ParametroTipo { get; set; }
        public String Abreviatura { get; set; }
        public Boolean Activo { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
