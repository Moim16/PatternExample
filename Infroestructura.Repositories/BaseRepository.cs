using Dominio.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infroestructura.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {/// <summary>
     /// Variable del Contexto de Base de Datos.
     /// </summary>
        protected readonly DbContext BaseDatosContexto;

        /// <summary>
        /// Colección de datos del repositorio, considerando el tipo de <see cref="T"/> correspondiente.
        /// </summary>
        protected readonly DbSet<T> BaseDatosColeccion;

        /// <summary>
        /// Constructor por defecto del repositorio.
        /// </summary>
        /// <param name="contexto">Instancia del contexto de Base de Datos.</param>
        public BaseRepository(DbContext contexto)
        {
            BaseDatosContexto = contexto;
            BaseDatosColeccion = contexto.Set<T>();
        }
        /// <summary>
        /// Actualiza la entidad a partir de su entidad modificada
        /// </summary>
        /// <param name="entidad">entidad generica</param>
        /// <returns>bool respuesta</returns>
        public async Task<bool> Actualizar(T entidad)
        {
            await Task.Run(() =>
            {
                BaseDatosColeccion.Attach(entidad);
                BaseDatosContexto.Entry(entidad).State = EntityState.Modified;
            });

            return true;
        }
        /// <summary>
        /// agrega registro a la entidad 
        /// </summary>
        /// <param name="entidad">entidad generica</param>
        /// <returns>bool respuesta</returns>
        public async Task<bool> Agregar(T entidad)
        {
            await BaseDatosColeccion.AddAsync(entidad);
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad">Listado de entidad generica</param>
        /// <returns>bool respuesta</returns>
        public async Task<bool> Agregar(IEnumerable<T> entidades)
        {
            await BaseDatosColeccion.AddRangeAsync(entidades);
            return true;
        }
        /// <summary>
        /// busca el registro segun el identificador
        /// </summary>
        /// <param name="Identidad">objeto con Identificador</param>
        /// <returns></returns>
        public async Task<T> Buscar(object Identidad)
        {
            try
            {
                return await BaseDatosColeccion.FindAsync(Identidad);
            }
            catch (Exception ex)
            {

            }
            return BaseDatosColeccion.Find(Identidad);
        }
        /// <summary>
        /// obtiene los datos a partir de una expresion
        /// </summary>
        /// <param name="predicado">predicado que contiene los parametros de busqueda</param>
        /// <returns></returns>
        public virtual async Task<IQueryable<T>> Buscar(Expression<Func<T, bool>> predicado)
        {
            var Query = await Task.Run(() =>
            {
                var query = BaseDatosColeccion.Where(predicado);
                return query;
            });
            return Query;
        }

        public IQueryable<T> ConsultaQuery()
        {
            return BaseDatosColeccion;
        }
        /// <summary>
        /// Elimina registro a partir de entidad existente
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns>bool resultado</returns>
        public async Task<bool> Eliminar(T entidad)
        {
            var Return = await Task.Run(() =>
            {
                if (BaseDatosContexto.Entry(entidad).State == EntityState.Detached)
                {
                    BaseDatosColeccion.Attach(entidad);
                }

                BaseDatosColeccion.Remove(entidad);
                return true;
            });
            return Return;
        }
        /// <summary>
        /// Obtiene el registro de la entidad a partir de expresion
        /// </summary>
        /// <param name="predicado">predicado que contiene los parametros de busqueda</param>
        /// <returns></returns>
        public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return await BaseDatosColeccion.FirstOrDefaultAsync(predicate);
            }
            return await BaseDatosColeccion.FirstOrDefaultAsync();
        }
        /// <summary>
        /// Obtiene todos los registros de la entidad consultada
        /// </summary>
        /// <returns>Iqueryable de entidad</returns>
        public async Task<IQueryable<T>> ObtenerTodo()
        {

            var query = await BaseDatosColeccion.ToListAsync();
            return query.AsQueryable();
        }
        /// <summary>
        /// Obtiene todos los registros de la entidad consultada a partir de expresion
        /// </summary>
        /// <param name="predicado">predicado que contiene los parametros de busqueda</param>
        /// <returns></returns>
        public virtual async Task<IQueryable<T>> ObtenerTodo(Expression<Func<T, bool>> predicado)
        {
            var Query = await Task.Run(() =>
            {
                var query = BaseDatosColeccion.Where(predicado);
                return query;
            });
            return Query;
        }
    }
}
