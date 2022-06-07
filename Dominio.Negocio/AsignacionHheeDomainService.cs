using Dominio.Contratos;
using Dominio.Entidades;
using Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Negocio
{
    public class AsignacionHheeDomainService : IAsignacionHheeDomainService
    {
        private readonly ITemplateUoW _templateUoW;
        public AsignacionHheeDomainService(ITemplateUoW templateUoW)
        {
            this._templateUoW = templateUoW;

        }
        public async Task<List<AsignacionHhee>> GetAll()
        {
            var retorno = await _templateUoW.asignacionHheeRepository.ObtenerTodo();
            return retorno.ToList();
        }

        public async Task<AsignacionHhee> GetById(int Id)
        {
            return await _templateUoW.asignacionHheeRepository.FirstOrDefaultAsync(x => x.IdAsignacionHhee == Id);
        }
    }
}
