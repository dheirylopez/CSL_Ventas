using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IConduceServices : ICommonOperationServices<Conduce>
    {
        Conduce GetId();
        void AddDetalle(DetalleConduce entity);
        Factura GetNombreId(string nombre);
        IEnumerable<DetalleFactura> GetDetalleNombreId(string nombre);
        Items GetItem(int Id);
        IEnumerable<Conduce> GetIdConduce(string nombre);
        Clientes GetCliente(int Id);
        DetalleConduce GetArticulo(int idConsuce, int idArticulo);
        IEnumerable<DetalleConduce> GetDetalleConduece(string nombre);
        IEnumerable<VistaConduce> GetVistaConduce();
        IEnumerable<VistaConduce> GetNombreIdVistaC(string nombre);
    }
    public class ConduceServices : IConduceServices
    {
        IConduceRepository _iconduceRepository = new ConduceRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Conduce> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Conduce entity)
        {
            _iconduceRepository.AddConduce(entity);
        }

        public void AddDetalle(DetalleConduce entity)
        {
            _iconduceRepository.AddDetalle(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Conduce entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conduce> Get()
        {
            throw new NotImplementedException();
        }

        public Conduce Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Conduce Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public DetalleConduce GetArticulo(int idConsuce, int idArticulo)
        {
            return _iconduceRepository.GetArticulo(idConsuce,idArticulo);
        }

        public IEnumerable<Conduce> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public Clientes GetCliente(int Id)
        {
          return  _iconduceRepository.GetCliente(Id);
        }

        public IEnumerable<DetalleConduce> GetDetalleConduece(string nombre)
        {
            return _iconduceRepository.GetDetalleConduece(nombre);
        }

        public IEnumerable<DetalleFactura> GetDetalleNombreId(string nombre)
        {
            return _iconduceRepository.GetDetalleNombreId(nombre);
        }

     
        public Conduce GetId()
        {
          return  _iconduceRepository.GetId();
        }

        public IEnumerable<Conduce> GetIdConduce(string nombre)
        {
            return _iconduceRepository.GetIdConduce(nombre);
        }

        public Items GetItem(int Id)
        {
            return _iconduceRepository.GetItem(Id);

        }

        public IEnumerable<Conduce> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conduce> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public Factura GetNombreId(string nombre)
        {
            return _iconduceRepository.GetNombreId(nombre);
        }

        public IEnumerable<VistaConduce> GetNombreIdVistaC(string nombre)
        {
            return _iconduceRepository.GetNombreIdVistaC(nombre);
        }

        public IEnumerable<VistaConduce> GetVistaConduce()
        {
            return _iconduceRepository.GetVistaConduce();
        }

        public void Update(Conduce entity)
        {
            _iconduceRepository.Update(entity);
        }
    }
}
