﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACONTRACT
{
    public class CicloBE
    {
        public int IdentCiclo { get; set; }
        public String Nombre { get; set; }
        public ParametroBE EstadoRegistro { get; set; }
        public UsuarioBE UsuarioCreador { get; set; }
        public UsuarioBE UsuarioModificacion { get; set; }
    }
}
