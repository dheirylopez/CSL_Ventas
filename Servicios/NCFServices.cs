using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface INCFServices : ICommonOperationServices<NCF>
    {

    }
    public class NCFServices : INCFServices
    {
        INCFRepository _INCFRepository = new NCFRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<NCF> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(NCF entity)
        {
            _INCFRepository.Add(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(NCF entity)
        {
            _INCFRepository.Delete(entity);
        }

        public IEnumerable<NCF> Get()
        {
            return _INCFRepository.Get();
        }

        public NCF Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public NCF Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NCF> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NCF> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NCF> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(NCF entity)
        {
            _INCFRepository.Update(entity);
        }
    }
}
