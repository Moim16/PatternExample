using System;
using System.Collections.Generic;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infroestructura.Contexto
{
    public partial class gv0013_devContext : DbContext
    {
        public gv0013_devContext()
        {
        }

        public gv0013_devContext(DbContextOptions<gv0013_devContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcuerdoHhee> AcuerdoHhees { get; set; } = null!;
        public virtual DbSet<AsignacionHhee> AsignacionHhees { get; set; } = null!;
        public virtual DbSet<AsignacionPerfil> AsignacionPerfils { get; set; } = null!;
        public virtual DbSet<AsignacionReemplazo> AsignacionReemplazos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {  

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcuerdoHhee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACUERDO_HHEE");

                entity.Property(e => e.EsFirmado).HasColumnName("ES_FIRMADO");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FIN");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INICIO");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.IdAcuerdoHhee)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_ACUERDO_HHEE");

                entity.Property(e => e.IdEmpresa).HasColumnName("ID_EMPRESA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioCreador).HasColumnName("ID_USUARIO_CREADOR");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("ID_USUARIO_MODIFICACION");

                entity.Property(e => e.MinutosAsignados).HasColumnName("MINUTOS_ASIGNADOS");
            });

            modelBuilder.Entity<AsignacionHhee>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionHhee)
                    .HasName("PK__ASIGNACI__6378E7FFD2E1966B");

                entity.ToTable("ASIGNACION_HHEE");

                entity.Property(e => e.IdAsignacionHhee).HasColumnName("ID_ASIGNACION_HHEE");

                entity.Property(e => e.ComentarioAprobacion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("COMENTARIO_APROBACION");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.EstadoAprobacion).HasColumnName("ESTADO_APROBACION");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_APROBACION");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FIN");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INICIO");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdUsuarioAprueba).HasColumnName("ID_USUARIO_APRUEBA");

                entity.Property(e => e.IdUsuarioCreador).HasColumnName("ID_USUARIO_CREADOR");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("ID_USUARIO_MODIFICACION");

                entity.Property(e => e.MinutosAsignados).HasColumnName("MINUTOS_ASIGNADOS");

                entity.Property(e => e.TiempoAprobado).HasColumnName("TIEMPO_APROBADO");
            });

            modelBuilder.Entity<AsignacionPerfil>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionPerfil)
                    .HasName("PK__ASIGNACI__836DCBB215790D66");

                entity.ToTable("ASIGNACION_PERFIL");

                entity.Property(e => e.IdAsignacionPerfil).HasColumnName("ID_ASIGNACION_PERFIL");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.IdEmpresa).HasColumnName("ID_EMPRESA");

                entity.Property(e => e.IdPerfilReemplazado).HasColumnName("ID_PERFIL_REEMPLAZADO");

                entity.Property(e => e.IdPerfilReemplazo).HasColumnName("ID_PERFIL_REEMPLAZO");

                entity.Property(e => e.IdUsuarioReemplazado).HasColumnName("ID_USUARIO_REEMPLAZADO");

                entity.Property(e => e.IdUsuarioReemplazo).HasColumnName("ID_USUARIO_REEMPLAZO");
            });

            modelBuilder.Entity<AsignacionReemplazo>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionReemplazo)
                    .HasName("PK__ASIGNACI__7DB4CFC886DC937F");

                entity.ToTable("ASIGNACION_REEMPLAZO");

                entity.Property(e => e.IdAsignacionReemplazo).HasColumnName("ID_ASIGNACION_REEMPLAZO");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FIN");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INICIO");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.IdEmpresa).HasColumnName("ID_EMPRESA");

                entity.Property(e => e.IdUsuarioCreador).HasColumnName("ID_USUARIO_CREADOR");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("ID_USUARIO_MODIFICACION");

                entity.Property(e => e.IdUsuarioReemplazado).HasColumnName("ID_USUARIO_REEMPLAZADO");

                entity.Property(e => e.IdUsuarioReemplazo).HasColumnName("ID_USUARIO_REEMPLAZO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
