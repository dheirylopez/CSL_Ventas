using System.Collections.Generic;

namespace Servicios
{
    public interface ICommonOperationServices<T> : IServiceBase<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Add(T entity);

        void Update(T entity);
        void Delete(T entity);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Add(IEnumerable<T> entities);

    }
}