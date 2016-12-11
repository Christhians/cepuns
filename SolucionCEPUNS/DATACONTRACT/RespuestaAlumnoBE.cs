using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public  class RespuestaAlumnoBE
    {
        public int IdentRespuestaAlumno { get; set; }
        public AlumnoBE Alumno { get; set; }
        public PreguntaBE Pregunta { get; set; }
        public ParametroBE ClaveMarcada { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
