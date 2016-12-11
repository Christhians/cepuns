using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class ExamenViewModel 
    {
        //
        // GET: /ExamenViewModel/
        public int IdentExamen { get; set; }
        public int Ciclo { get; set; }
        public int Grupo { get; set; }
        public DateTime? FechaExamen { get; set; }
        public String NombreExamen { get; set; }
        public String ExamenPDF { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
