using Dapper;
using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICotizacionRepository: IRepositoryBase<Cotizacion>
    {
        IEnumerable<Clientes> GetCliente();
        IEnumerable<Items> GetArticulo();
        Almacen GetItemAlmacen(int Id);
        void AddDetalle(DetalleCotizacion entity);
        IEnumerable<Almacen> GetAlmacen();
        Cotizacion GetNombreIdCotizacion(string nombre);
        void AddCotizacion(Cotizacion item);
        void Update(Cotizacion item);
        void Delete(Cotizacion item);
        Cotizacion GetNombreId(string nombre);
        Cotizacion GetId();
        IEnumerable<DetalleCotizacion> GetDetalleNombreId(string nombre);

        IEnumerable<VistaCotizacion> GetVistaCotizacion();
        IEnumerable<VistaCotizacion> GetNombreIdVistaC(string nombre);

    }
    public class CotizacionRepository : RepositoryBase<Cotizacion>, ICotizacionRepository
    {
        public CotizacionRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {

        }

        public void AddDetalle(DetalleCotizacion entity)
        {
            var query = base.BuilderOfInsert(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void AddCotizacion(Cotizacion item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Almacen> GetAlmacen()
        {
            throw new NotImplementedException();
        }
        public Almacen GetItemAlmacen(int Id)
        {
            var query = new StringBuilder(string.Format("select * from Almacen where idItems = {0}", Id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Almacen>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }
        public IEnumerable<Items> GetArticulo()
        {
            var query = new StringBuilder("select * from Items");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Items>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<Clientes> GetCliente()
        {
            var query = new StringBuilder("select * from Cliente");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Clientes>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<DetalleCotizacion> GetDetalleNombreId(string nombre)
        {
            throw new NotImplementedException();
        }

        public Cotizacion GetId()
        {
            var query = new StringBuilder("select max(id) as id from Cotizacion ");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Cotizacion>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

    

        public Cotizacion GetNombreId(string nombre)
        {
            throw new NotImplementedException();
        }

        public Cotizacion GetNombreIdCotizacion(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from cotizacion where id = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Cotizacion>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public IEnumerable<VistaCotizacion> GetVistaCotizacion()
        {
            var query = new StringBuilder(string.Format("select * from View_Cotizacion  "));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaCotizacion>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<VistaCotizacion> GetNombreIdVistaC(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from View_Cotizacion where id like '%{0}%' or cliente like '%{0}%' or colaborador like '%{0}%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaCotizacion>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }
}
