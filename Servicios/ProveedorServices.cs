using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IProveedorServices : ICommonOperationServices<Proveedor>
    {
        IEnumerable<Proveedor> GetNombreId(string nombre);
        Proveedor GetNombreId(int nombre);
    }
    public class ProveedorServices : IProveedorServices
    {

        IProveedorRepository _iproveedorrepository = new ProveedorRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Proveedor> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Proveedor entity)
        {
            _iproveedorrepository.AddProveedor(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Proveedor entity)
        {
            _iproveedorrepository.DeleteProveedor(entity);
        }

        public IEnumerable<Proveedor> Get()
        {
          return  _iproveedorrepository.Get();
        }

        public Proveedor Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Proveedor Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> GetNombreId(string nombre)
        {
            return _iproveedorrepository.GetNombreId(nombre);
        }

        public Proveedor GetNombreId(int nombre)
        {
            return _iproveedorrepository.GetNombreId(nombre);
        }

        public void Update(Proveedor entity)
        {
            _iproveedorrepository.UpdateProveedor(entity);
        }
    }
}
