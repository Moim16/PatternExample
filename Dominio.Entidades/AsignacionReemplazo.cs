using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public partial class AsignacionReemplazo
    {
        public long IdAsignacionReemplazo { get; set; }
        public long IdUsuarioReemplazo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long IdUsuarioCreador { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public long? IdUsuarioModificacion { get; set; }
        public long? IdUsuarioReemplazado { get; set; }
        public long? IdEmpresa { get; set; }
    }
}
