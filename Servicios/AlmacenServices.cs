using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IAlmacenServices : ICommonOperationServices<Almacen>
    {
        void AddHistoricoAlmacen(HistoricoAlmacen item);
        void AddArticulo(Items item);
        void UpdateArticulo(Items item);
        void DeleteArticulo(Items item);
        IEnumerable<Items> GetArticulo();
        IEnumerable<Proveedor> GetProveedpr();
        IEnumerable<Items> GetArticuloNombreId(string nombre);
        IEnumerable<Almacen> GetNombreId(string nombre);
        Almacen GetarticuloAlmacen(string nombre);
        IEnumerable<Inventario> GetInventario();
        IEnumerable<Inventario> GetInveNombreId(string nombre);
        Items GetArticuloNombreId();
        void AddDetalle(DetalleItems entity);
        void DeleteDetalle(int id);
        IEnumerable<DetalleItems> GetDetalleItems(int iditems);
    }
    public class AlmacenServices : IAlmacenServices
    {
        IAlmacenRepository _ialmacenRepository = new AlmacenRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Almacen> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Almacen entity)
        {
            _ialmacenRepository.AddAlmacen(entity);
        }

        public void AddArticulo(Items item)
        {
            _ialmacenRepository.AddArticulo(item);
        }

        public void AddDetalle(DetalleItems entity)
        {
            _ialmacenRepository.AddDetalle(entity);
        }

        public void AddHistoricoAlmacen(HistoricoAlmacen item)
        {
            _ialmacenRepository.AddHistoricoAlmacen(item);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Almacen entity)
        {
            _ialmacenRepository.DeleteAlmacen(entity);
        }

    

        public void DeleteArticulo(Items item)
        {
            _ialmacenRepository.DeleteArticulo(item);
        }

        public void DeleteDetalle(int id)
        {
            _ialmacenRepository.DeleteDetalle(id);
        }

        public IEnumerable<Almacen> Get()
        {
            return _ialmacenRepository.Get();
        }

        public Almacen Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Almacen Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Items> GetArticulo()
        {
            return _ialmacenRepository.GetArticulo();
        }

        public Almacen GetarticuloAlmacen(string nombre)
        {
            return _ialmacenRepository.GetarticuloAlmacen(nombre);
        }
        public Items GetArticuloNombreId()
        {
            return _ialmacenRepository.GetArticuloNombreId();
        }
        public IEnumerable<Items> GetArticuloNombreId(string nombre)
        {
            return _ialmacenRepository.GetArticuloNombreId(nombre);
        }

        public IEnumerable<Almacen> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventario> GetInveNombreId(string nombre)
        {
            return _ialmacenRepository.GetInveNombreId(nombre);
        }

        public IEnumerable<Inventario> GetInventario()
        {
            return _ialmacenRepository.GetInventario();
        }

        public IEnumerable<Almacen> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> GetNombreId(string nombre)
        {
            return _ialmacenRepository.GetNombreId(nombre);
        }

        public IEnumerable<Proveedor> GetProveedpr()
        {
          return  _ialmacenRepository.GetProveedor();
        }

        public void Update(Almacen entity)
        {
            _ialmacenRepository.UpdateAlmacen(entity);
        }

      
        public void UpdateArticulo(Items item)
        {
            _ialmacenRepository.UpdateArticulo(item);
        }
        public IEnumerable<DetalleItems> GetDetalleItems(int iditems)
        {
            return _ialmacenRepository.GetDetalleItems(iditems);
        }

    }
}
