using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionCEPUNS.Models
{
    public class RespuestaAlumnoViewModel
    {
        //
        // GET: /RespuestaAlumnoViewModel/

        public int IdentRespuestaAlumno { get; set; }
        public int Alumno { get; set; }
        public int Pregunta { get; set; }
        public int ClaveMarcada { get; set; }
        public int EstadoRegistro { get; set; }
        public int UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }


    }
}
