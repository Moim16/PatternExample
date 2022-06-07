using Dominio.Contratos;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infroestructura.Repositories
{
    public class AsignacionHheeRepository : BaseRepository<AsignacionHhee>, IAsignacionHheeRepository
    {
        public AsignacionHheeRepository(DbContext contexto) : base(contexto)
        {
        }
    }
}
