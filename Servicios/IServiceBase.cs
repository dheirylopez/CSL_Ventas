using System.Collections.Generic;
using System.Threading;

namespace Servicios
{
    public interface IServiceTaskBase
    {
        CancellationTokenSource CancellationToken { get; set; }
    }
    public interface IServiceBase<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        T Get(KeyValuePair<string, int> value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        T Get(KeyValuePair<string, string> value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IEnumerable<T> GetList(KeyValuePair<string, int> value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IEnumerable<T> GetList(KeyValuePair<string, string> value);

        IEnumerable<T> GetByStoredProcedure(object parameters);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Count();
        //TODO: Remove this stuff
        IEnumerable<string> GetCircuit();
    }
}