using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public  class ExamenBE
    {
        public int IdentExamen { get; set; }
        public CicloBE IdentCiclo { get; set; }
        public GrupoBE IdentGrupo { get; set; }        
        public DateTime? FechaExamen { get; set; }
        public String NombreExamen { get; set; }
        public String ExamenPDF { get; set; }     
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
