using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicios
{
    public interface IAsignacionHheeDomainService
    {
        /// <summary>
        /// Retorna todos los registros de correos de la entidad
        /// </summary>
        /// <returns>List of EnvioEmail</returns>
        Task<List<AsignacionHhee>> GetAll();

        /// <summary>
        /// Retorna todos los registros de correos de la entidad
        /// </summary>
        /// <returns>List of EnvioEmail</returns>
        Task<AsignacionHhee> GetById(int Id);
    }
}
