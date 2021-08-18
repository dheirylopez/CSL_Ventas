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
    public interface IFacturaRepository: IRepositoryBase<Factura>
    {
        IEnumerable<Clientes> GetCliente();
        IEnumerable<VistaFactura> GetVistaFacturaCredito();
        IEnumerable<VistaFactura> GetVistaFacturaContado();
        IEnumerable<Items> GetArticulo();
        Almacen GetItemAlmacen(int Id);
        void AddFactura(Factura item);
        void UpdateFactura(Factura item);
        void DeleteFactura(Factura item);
       Cotizacion GetNombreId(string nombre);
       Factura GetId();
        Factura GetNombreIdFactura(string nombre);
        void AddDetalle(DetalleFactura entity);
        IEnumerable<DetalleCotizacion> GetDetalleNombreId(string nombre);
       NCF GetId(int Estatus, string Tipo);
        NCF GetNCF(string id);
        NCF GetNCFCodigo(string id);
        Factura GetId(int id);
        void AddCierre(Cierre entity);
        void UpdateCierre(Cierre entity);
        Cierre GetIdCierre(int id);
        Cierre GetIdCierre(DateTime fecha);
        Cierre GetIdCierre();
        IEnumerable<VistaFactura> GetVistaFactura();
        IEnumerable<VistaFactura> GetNombreIdVistaF(string nombre);
    }
    public class FacturaRepository : RepositoryBase<Factura>, IFacturaRepository
    {
        public FacturaRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {

        }

        public void AddDetalle(DetalleFactura entity)
        {

            var query = base.BuilderOfInsert(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }


        public void AddFactura(Factura item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void DeleteFactura(Factura item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
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
            var query = new StringBuilder(string.Format("select * from DetalleCotizacion where idCotizacion = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<DetalleCotizacion>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Factura GetId()
        {
            var query = new StringBuilder("select max(id) as id from factura ");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Factura>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public NCF GetId(int Estatus, string Tipo )
        {
            var query = new StringBuilder(string.Format("select max(c.Id) as id,c.Codigo,c.Tipo from NCF c  WHERE  Estatus = '{0}' and Tipo= '{1}'  group by c.Tipo,c.Codigo", Estatus,Tipo));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<NCF>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }
        public NCF GetNCF(string id)
        {
            var query = new StringBuilder(string.Format("select * from NCF c  WHERE  id ='{0}' ", id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<NCF>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }
        public NCF GetNCFCodigo(string id)
        {
            var query = new StringBuilder(string.Format("select * from NCF  WHERE  codigo ='{0}' ", id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<NCF>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }
        public Almacen GetItemAlmacen(int Id)
        {
            var query = new StringBuilder(string.Format("select * from Almacen where Iditems = {0}", Id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Almacen>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public Cotizacion GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Cotizacion where id = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Cotizacion>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public void UpdateFactura(Factura item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public Factura GetNombreIdFactura(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from factura where id = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Factura>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public IEnumerable<VistaFactura> GetVistaFactura()
        {
            var query = new StringBuilder("select * from [dbo].[View_Factura]");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaFactura>(query.ToString(), commandTimeout: CommandTimeout);
        }
 
       
        public IEnumerable<VistaFactura> GetNombreIdVistaF(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from [dbo].[View_Factura]  where id like '%{0}%' or cliente like '%{0}%' or empleado like '%{0}%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaFactura>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Factura GetId(int id)
        {
            var query = new StringBuilder(string.Format("select * from factura where id = {0}",id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Factura>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public void AddCierre(Cierre entity)
        {
            var query = base.BuilderOfInsert(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void UpdateCierre(Cierre entity)
        {
            var query = base.BuilderOfUpdate(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public Cierre GetIdCierre(int id)
        {
            var query = new StringBuilder(string.Format("select * from CierreDia where id = {0} ", id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Cierre>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }
        public Cierre GetIdCierre(DateTime fecha)
        {
            var _fecha = fecha.Date.ToString("yyy/MM/dd");
            var query = new StringBuilder(string.Format("select * from CierreDia where  fecha = '{0}'",_fecha ));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Cierre>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public Cierre GetIdCierre()
        {
            var query = new StringBuilder("select max(id) as id from CierreDia ");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Cierre>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public IEnumerable<VistaFactura> GetVistaFacturaContado()
        {
            var query = new StringBuilder(string.Format("select * from [dbo].[View_Factura]  where  Pago_Pendiente > 0"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaFactura>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<VistaFactura> GetVistaFacturaCredito()
        {
            var query = new StringBuilder(string.Format("select * from [dbo].[View_Factura]  where  Pago_Pendiente = 0"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaFactura>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }
}
