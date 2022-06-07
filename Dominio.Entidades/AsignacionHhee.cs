using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public partial class AsignacionHhee
    {
        public long IdAsignacionHhee { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public short MinutosAsignados { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long IdUsuarioCreador { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public long? IdUsuarioModificacion { get; set; }
        public bool? EstadoAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public long? IdUsuarioAprueba { get; set; }
        public string? ComentarioAprobacion { get; set; }
        public TimeSpan? TiempoAprobado { get; set; }
    }
}
