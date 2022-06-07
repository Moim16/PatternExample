using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core
{
    public interface IBaseRepository<T> where T : class
    { /// <summary>
      /// Agregar una nueva entidad
      /// </summary>
      /// <param name="entidad">entidad a agregar</param>
        Task<bool> Agregar(T entidad);
        /// <summary>
        /// Agregar una Lista de entidades
        /// </summary>
        /// <param name="entidades">Lista de entidades</param>
        Task<bool> Agregar(IEnumerable<T> entidades);
        /// <summary>
        /// Actualiza la entidad
        /// </summary>
        /// <param name="entidad">entidad a actualizar</param>
        /// <returns></returns>
        Task<bool> Actualizar(T entidad);
        /// <summary>
        /// Elimina la entidad
        /// </summary>
        /// <param name="entidad">entidad a eliminar</param>
        /// <returns></returns>
        Task<bool> Eliminar(T entidad);
        /// <summary>
        /// Consulta de busqueda de una entidad
        /// </summary>
        /// <param name="Identidad">Id de la entidad</param>
        /// <returns></returns>
        Task<T> Buscar(object Identidad);

        /// <summary>
        /// Declaración del metodo.
        /// </summary>
        /// <param name="predicado">Predicado de busqueda de elementos.</param>
        /// <returns>Lista de elementos buscados.</returns>
        Task<IQueryable<T>> Buscar(System.Linq.Expressions.Expression<Func<T, bool>> predicado);
        /// <summary>
        /// Obtiene todos los elmentos del tipo entidad
        /// </summary>
        /// <returns>un IQueryable de entidad</returns>
        Task<IQueryable<T>> ObtenerTodo();
        /// <summary>
        /// Obtiene todos los lementos del tipo de entidad segun el predicado
        /// </summary>
        /// <param name="pericado">expression labda</param>
        /// <returns></returns>
        Task<IQueryable<T>> ObtenerTodo(Expression<Func<T, bool>> predicado);
        /// <summary>
        /// Consulta a la base de datos por medio de query
        /// </summary>
        /// <returns></returns>
        IQueryable<T> ConsultaQuery();
        /// <summary>
        /// Obtiene el registro de la entidad a partir de expresion
        /// </summary>
        /// <param name="predicate">Contiene los parametros a consultar</param>
        /// <returns>Object de tipo entidad</returns>
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate = null);
    }
}
