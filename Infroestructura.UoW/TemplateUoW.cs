using Dominio.Contratos;
using Infroestructura.Contexto;
using Infroestructura.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infroestructura.UoW
{
    public class TemplateUoW : ITemplateUoW
    {
        private bool disposed = false;
        private IAsignacionHheeRepository _asignacionHheeRepository;
        private readonly gv0013_devContext contexto;
        public TemplateUoW(gv0013_devContext contexto)
        {
            this.contexto = contexto;
        }

        public IAsignacionHheeRepository asignacionHheeRepository
        {
            get
            {
                _asignacionHheeRepository = new AsignacionHheeRepository(contexto);
                return _asignacionHheeRepository;
            }
        }
        public void BeginTransaction()
        {
            contexto.Database.BeginTransaction();
        }
        public void Commit()
        {
            try
            {
                contexto.SaveChanges();
                if (contexto.Database.CurrentTransaction != null)
                {
                    contexto.Database.CurrentTransaction.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    contexto.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void RollBack()
        {
            contexto.Database.CurrentTransaction.Rollback();
        }
    }
}
