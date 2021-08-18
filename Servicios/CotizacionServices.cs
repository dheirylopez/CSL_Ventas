using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface ICotizacionServices: ICommonOperationServices<Cotizacion>
    {
        IEnumerable<Clientes> GetCliente();
        IEnumerable<Items> GetArticulo();
        Almacen GetItemAlmacen(int Id);
        void AddDetalle(DetalleCotizacion entity);
        IEnumerable<Almacen> GetAlmacen();
        Cotizacion GetNombreIdFactura(string nombre);
        Cotizacion GetId();
        IEnumerable<VistaCotizacion> GetVistaCotizacion();
        IEnumerable<VistaCotizacion> GetNombreIdVistaC(string nombre);
    }
    public class CotizacionServices : ICotizacionServices
    {
        ICotizacionRepository _iCotizacionRepository = new CotizacionRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Cotizacion> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Cotizacion entity)
        {
            _iCotizacionRepository.AddCotizacion(entity);
        }

        public void AddDetalle(DetalleCotizacion entity)
        {
            _iCotizacionRepository.AddDetalle(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Cotizacion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cotizacion> Get()
        {
            throw new NotImplementedException();
        }

        public Cotizacion Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Cotizacion Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> GetAlmacen()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Items> GetArticulo()
        {
           return _iCotizacionRepository.GetArticulo();
        }

        public IEnumerable<Cotizacion> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clientes> GetCliente()
        {
            return _iCotizacionRepository.GetCliente();
        }

        public Cotizacion GetId()
        {
            return _iCotizacionRepository.GetId();
        }

        public Almacen GetItemAlmacen(int Id)
        {
            return _iCotizacionRepository.GetItemAlmacen(Id);
        }

        public IEnumerable<Cotizacion> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cotizacion> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public Cotizacion GetNombreIdFactura(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VistaCotizacion> GetNombreIdVistaC(string nombre)
        {
            return _iCotizacionRepository.GetNombreIdVistaC(nombre);
        }

        public IEnumerable<VistaCotizacion> GetVistaCotizacion()
        {
            return _iCotizacionRepository.GetVistaCotizacion();
        }

        public void Update(Cotizacion entity)
        {
            _iCotizacionRepository.Update(entity);
        }
    }
}
