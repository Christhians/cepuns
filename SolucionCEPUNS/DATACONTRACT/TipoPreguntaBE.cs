using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class TipoPreguntaBE
    {
        public int IdentTipoPregunta { get; set; }
        public CicloBE IdentAperturaCiclo { get; set; }
        public String Descrpcion { get; set; }
        public decimal PuntajeRespuestaCorrecta { get; set; }
        public decimal PuntajeRespuestaErronea{ get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
