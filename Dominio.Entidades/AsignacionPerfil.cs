using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public partial class AsignacionPerfil
    {
        public long IdAsignacionPerfil { get; set; }
        public long IdUsuarioReemplazo { get; set; }
        public long IdPerfilReemplazo { get; set; }
        public long? IdUsuarioReemplazado { get; set; }
        public long IdPerfilReemplazado { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long? IdEmpresa { get; set; }
    }
}
