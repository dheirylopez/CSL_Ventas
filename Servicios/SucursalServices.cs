using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface ISucursalServices : ICommonOperationServices<Sucursal>
    {
        IEnumerable<Sucursal> GetNombreId(string nombre);
     Sucursal GetNombreId(int nombre);
        IEnumerable<Compania> Get(string nombre);
     IEnumerable<Compania> GetCompania();
        Compania Get(int nombre);

    }



    public class SucursalServices : ISucursalServices
    {
        private readonly ISucursalRepository _sucursalRepository = new SucursalRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Sucursal> entities)
        {
            throw new NotImplementedException();
        }


        public void Add(Sucursal entity)
        {

            _sucursalRepository.AddSucursal(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Sucursal entity)
        {
            _sucursalRepository.DeleteSucursal(entity);
        }

        public IEnumerable<Sucursal> Get()
        {
            return _sucursalRepository.Get();
        }
        public void Update(Sucursal entity)
        {
            _sucursalRepository.UpdateSucursal(entity);
        }


        public IEnumerable<Sucursal> GetNombreId(string nombre)
        {
           return _sucursalRepository.GetNombreId(nombre);
        }
        public Sucursal Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public Sucursal Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Sucursal> IServiceBase<Sucursal>.GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Sucursal> IServiceBase<Sucursal>.GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Sucursal> IServiceBase<Sucursal>.GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public Sucursal GetNombreId(int nombre)
        {
            return _sucursalRepository.GetNombreId(nombre);
        }

       

        

        public Compania Get(int nombre)
        {
            return _sucursalRepository.Get(nombre);
        }

        public IEnumerable<Compania> Get(string nombre)
        {
            return _sucursalRepository.Get(nombre);
        }

        public IEnumerable<Compania> GetCompania()
        {
            return _sucursalRepository.GetCompania();
        }
    }
}
