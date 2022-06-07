using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public partial class AcuerdoHhee
    {
        public long IdAcuerdoHhee { get; set; }
        public long IdUsuario { get; set; }
        public long IdEmpresa { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public short MinutosAsignados { get; set; }
        public bool EsFirmado { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long IdUsuarioCreador { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public long? IdUsuarioModificacion { get; set; }
    }
}
