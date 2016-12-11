using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public class ResultadoBE
    {
        public int IdentResultado { get; set; }
        public ExamenBE Examen { get; set; }
        public AlumnoBE Alumno { get; set; }
        public decimal PuntajeConocimiento { get; set; }
        public decimal PuntajeRazonamiento { get; set; }
        public decimal PuntajeTotal { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }



    }
}
