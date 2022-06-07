using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos
{
    public interface ITemplateUoW : IDisposable
    {
        IAsignacionHheeRepository asignacionHheeRepository
        {
            get;
        }
        #region Dispose y commit.
        /// <summary>
        /// Método de dispose de la clase.
        /// </summary>
        /// <param name="disposing">Indicador de dispose.</param>
        void Dispose(bool disposing);

        /// <summary>
        /// Método para persistencia en la base de datos.
        /// </summary>
        void Commit();

        /// <summary>
        /// Método para iniciar una transaccion de Base de Datos. 
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Método para deshacer todos las operaciones realizadas en la Base de Datos por transaccion. 
        /// </summary>
        void RollBack();
        #endregion
    }
}
