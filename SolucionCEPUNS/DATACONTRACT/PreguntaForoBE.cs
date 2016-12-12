using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public  class PreguntaForoBE
    {
        public int identPreguntaForo { get; set; }
        public String tituloPreguntaForo { get; set; }
        public String descripcionPreguntaForo { get; set; }
        public DateTime? fechaPreguntaForo { get; set; }
        public UsuarioBE UsuarioPublicador  { get; set; }
       
    }
}
