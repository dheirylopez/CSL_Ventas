using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IFacturaServices : ICommonOperationServices<Factura>
    {
        IEnumerable<VistaFactura> GetVistaFacturaCredito();
        IEnumerable<Clientes> GetCliente();
        IEnumerable<VistaFactura> GetVistaFacturaContado();
        IEnumerable<Empleados> GetEmpleados();
        IEnumerable<Items> GetArticulo();
        Almacen GetItemAlmacen(int Id);
        Items GetItem(int Id);
        Cotizacion GetNombreId(string nombre);
        Factura GetId();
        IEnumerable<DetalleCotizacion> GetDetalleNombreId(string nombre);
        void AddDetalle(DetalleFactura entity);
        void AddCierre(Cierre entity);
        void UpdateCierre(Cierre entity);
        Cierre GetIdCierre(int id);
        Cierre GetIdCierre();
        Cierre GetIdCierre(DateTime fecha);
        IEnumerable<Almacen> GetAlmacen();
        NCF GetId(int Estatus, string Tipo);
        NCF GetNCF(string id);
        void UpdateNCF(NCF entity);
        void UpdateAlmacen(Almacen entity);
        Factura GetNombreIdFactura(string nombre);
        NCF GetNCFCodigo(string id);
        IEnumerable<VistaFactura> GetVistaFactura();
        IEnumerable<VistaFactura> GetVistaFacturaProforma();
        IEnumerable<VistaFactura> GetNombreIdVistaF(string nombre);
        IEnumerable<DetalleItems> GetDetalleItems(int iditems);
        Factura GetId(int id);

    }
    public class FacturaServices : IFacturaServices
    {
        iSeguridadRepository _iSeguridadRepository = new SeguridadRepository(Conexion.GetDbConnectionSQL());
         IFacturaRepository _IfacturaRepository = new FacturaRepository(Conexion.GetDbConnectionSQL());
        IAlmacenRepository _ialmacenRepository = new AlmacenRepository(Conexion.GetDbConnectionSQL());
        INCFRepository _iNCFRepository = new NCFRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Factura> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Factura entity)
        {
            _IfacturaRepository.AddFactura(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Factura entity)
        {
            _IfacturaRepository.DeleteFactura(entity);
        }

        public IEnumerable<Factura> Get()
        {
            return _IfacturaRepository.Get();
        }

        public Factura Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Factura Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Items> GetArticulo()
        {
            return _IfacturaRepository.GetArticulo();
        }

        public IEnumerable<Factura> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clientes> GetCliente()
        {
            return _IfacturaRepository.GetCliente();
        }

        public Factura GetId()
        {
            return _IfacturaRepository.GetId();
        }

        public Almacen GetItemAlmacen(int Id)
        {
            return _IfacturaRepository.GetItemAlmacen(Id);
        }

        public IEnumerable<Factura> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Factura> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public Cotizacion GetNombreId(string nombre)
        {
            return _IfacturaRepository.GetNombreId(nombre);
        }
        public IEnumerable<DetalleCotizacion> GetDetalleNombreId(string nombre)
        {
            return _IfacturaRepository.GetDetalleNombreId(nombre);
        }
        public void Update(Factura entity)
        {
            _IfacturaRepository.UpdateFactura(entity);
        }

        public void AddDetalle(DetalleFactura entity)
        {
            _IfacturaRepository.AddDetalle(entity);
        }

        public IEnumerable<Almacen> GetAlmacen()
        {
            throw new NotImplementedException();
        }

        public NCF GetId(int Estatus, string Tipo)
        {
         return   _IfacturaRepository.GetId(Estatus,Tipo);
        }

        public void UpdateNCF(NCF entity)
        {
            _iNCFRepository.Update(entity);
        }

        public void UpdateAlmacen(Almacen entity)
        {
            _ialmacenRepository.UpdateAlmacen(entity);
        }

        public NCF GetNCF(string id)
        {
            return _IfacturaRepository.GetNCF(id);
        }

        public Factura GetNombreIdFactura(string nombre)
        {
           return _IfacturaRepository.GetNombreIdFactura(nombre);
        }

        public NCF GetNCFCodigo(string id)
        {
          return  _IfacturaRepository.GetNCFCodigo(id);
        }
        public IEnumerable<VistaFactura> GetVistaFacturaProforma()
        {
            return _IfacturaRepository.GetVistaFactura();
        }
        public IEnumerable<VistaFactura> GetVistaFactura()
        {
           return _IfacturaRepository.GetVistaFactura();
           
        }
        public IEnumerable<VistaFactura> GetVistaFacturaContado()
        {
            return   _IfacturaRepository.GetVistaFacturaContado();
          
        }
        public IEnumerable<VistaFactura> GetVistaFacturaCredito()
        {
            return _IfacturaRepository.GetVistaFacturaCredito();

        }
        public IEnumerable<VistaFactura> GetNombreIdVistaF(string nombre)
        {
            return _IfacturaRepository.GetNombreIdVistaF(nombre);
        }

        public Items GetItem(int Id)
        {
            return _ialmacenRepository.GetItem(Id);
        }

        public IEnumerable<Empleados> GetEmpleados()
        {
            return _iSeguridadRepository.GetEmpleado();
        }

        public IEnumerable<DetalleItems> GetDetalleItems(int iditems)
        {
            return _ialmacenRepository.GetDetalleItems(iditems);
        }

        public Factura GetId(int id)
        {
            return _IfacturaRepository.GetId(id);
        }

        public void AddCierre(Cierre entity)
        {
            _IfacturaRepository.AddCierre(entity);
        }

        public void UpdateCierre(Cierre entity)
        {
            _IfacturaRepository.UpdateCierre(entity);
        }

        public Cierre GetIdCierre(int id)
        {
            return _IfacturaRepository.GetIdCierre(id);
        }

        public Cierre GetIdCierre(DateTime fecha)
        {
          return  _IfacturaRepository.GetIdCierre(fecha);
        }

        public Cierre GetIdCierre()
        {
            return _IfacturaRepository.GetIdCierre();
        }
    }
}
