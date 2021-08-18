using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IClientesServices : ICommonOperationServices<Clientes>
    {
        IEnumerable<Clientes> GetNombreId(string nombre);
        Clientes GetNombreId(int nombre);
    }



    public class ClientesServices : IClientesServices
    {
        private readonly IClienteRepository _clienteRepository = new ClienteRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Clientes> entities)
        {
            throw new NotImplementedException();
        }


        public void Add(Clientes entity)
        {

            _clienteRepository.AddCliente(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Clientes entity)
        {
            _clienteRepository.DeleteCliente(entity);
        }

        public IEnumerable<Clientes> Get()
        {
            return _clienteRepository.Get();
        }
        public void Update(Clientes entity)
        {
            _clienteRepository.UpdateCliente(entity);
        }


        public IEnumerable<Clientes> GetNombreId(string nombre)
        {
           return _clienteRepository.GetNombreId(nombre);
        }

        public Clientes Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public Clientes Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clientes> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clientes> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clientes> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public Clientes GetNombreId(int nombre)
        {
           return _clienteRepository.GetNombreId(nombre);
        }
    }
}
