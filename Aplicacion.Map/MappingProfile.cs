using Aplicacion.DTO;
using AutoMapper;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Map
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //se encarga de crear el mapeo para vincular entidad con entidad dto
            CreateMap<AsignacionHheeDTO, AsignacionHhee>().ReverseMap();
        }
    }
}
