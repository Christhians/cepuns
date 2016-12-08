using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
  public   class ComentarioForoBE
    {
        public int identComentarioForo { get; set; }
        public String ComentarioForo { get; set; }
        public DateTime? FechaComentarioForo { get; set; }
        public PreguntaForoBE identPreguntaForo { get; set; }
        public UsuarioBE identUsuario { get; set; }
    }
}
