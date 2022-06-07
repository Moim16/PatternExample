using Aplicacion.Contrato;
using Aplicacion.Servicio;
using Dominio.Contratos;
using Dominio.Negocio;
using Dominio.Servicios;
using Infroestructura.Contexto;
using Infroestructura.Repositories;
using Infroestructura.UoW;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IoCService
    {
        public static void Servicios(this IServiceCollection services)
        {
            //se registran los servicios del negocio
            services.AddScoped<IAsignacionHheeAplicationService, AsignacionHheeAplicationService>();
            services.AddScoped<IAsignacionHheeDomainService, AsignacionHheeDomainService>();
        }

        public static void Repositorio(this IServiceCollection services)
        {
            //se agregan los repositorios 
            services.AddScoped<Microsoft.EntityFrameworkCore.DbContext, gv0013_devContext>();
            services.AddScoped<ITemplateUoW, TemplateUoW>();
            services.AddScoped<IAsignacionHheeRepository, AsignacionHheeRepository>();
        }
    }
}
