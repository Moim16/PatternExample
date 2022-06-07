using Aplicacion.Contrato;
using Aplicacion.DTO;
using AutoMapper;
using Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicio
{
    public class AsignacionHheeAplicationService : IAsignacionHheeAplicationService
    {
        private readonly IAsignacionHheeDomainService _asignacionHheeDomainService;
        private readonly IMapper _mapper;

        public AsignacionHheeAplicationService(IAsignacionHheeDomainService asignacionHheeDomainService,
            IMapper mapper)
        {
            this._asignacionHheeDomainService = asignacionHheeDomainService;
            this._mapper = mapper;
        }
        public async Task<List<AsignacionHheeDTO>> GetAll()
        {
            var retornoEntidad = await _asignacionHheeDomainService.GetAll();
            var retornoMap = _mapper.Map<List<AsignacionHheeDTO>>(retornoEntidad);
            return retornoMap;
        }

        public async Task<AsignacionHheeDTO> GetById(int Id)
        {
            var retornoEntidad = await _asignacionHheeDomainService.GetById(Id);
            var retornoMap = _mapper.Map<AsignacionHheeDTO>(retornoEntidad);
            return retornoMap;
        }
    }
}
