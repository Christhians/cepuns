using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class UsuarioViewModel 
    {
        //
        // GET: /UsuarioViewModel/

        public int identUsuario { get; set; }
        public String cuenta { get; set; }
        public String password { get; set; }

    }
}
