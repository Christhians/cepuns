﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
   public class GrupoBE
    {
        public int IdentGrupo { get; set; }
        public String NombreGrupo { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
