using Aplicacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Contrato
{
    public interface IAsignacionHheeAplicationService
    {
        /// <summary>
        /// Retorna todos los registros de correos de la entidad
        /// </summary>
        /// <returns>List of EnvioEmail</returns>
        Task<List<AsignacionHheeDTO>> GetAll();

        /// <summary>
        /// Retorna todos los registros de correos de la entidad
        /// </summary>
        /// <returns>List of EnvioEmail</returns>
        Task<AsignacionHheeDTO> GetById(int Id);
    }
}
