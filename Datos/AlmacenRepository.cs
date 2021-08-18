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
   public interface IAlmacenRepository: IRepositoryBase<Almacen>
    {
        void AddAlmacen(Almacen item);
        void UpdateAlmacen(Almacen item);
      
        void DeleteAlmacen(Almacen item);
        void DeleteDetalle(int id);
        void AddHistoricoAlmacen(HistoricoAlmacen item);
        IEnumerable<Almacen> GetNombreId(string nombre);
        Almacen GetarticuloAlmacen(string nombre);
        void AddArticulo(Items item);
        void UpdateArticulo(Items item);
        void DeleteArticulo(Items item);
        Items GetItem(int Id);
        IEnumerable<Proveedor> GetProveedor();
        IEnumerable<Items> GetArticulo();
        IEnumerable<Items> GetArticuloNombreId(string nombre);
        Items GetArticuloNombreId();
        IEnumerable<Inventario> GetInventario();
        IEnumerable<Inventario> GetInveNombreId(string nombre);
        void AddDetalle(DetalleItems entity);
        IEnumerable<DetalleItems> GetDetalleItems(int iditems);
    }
  public  class AlmacenRepository : RepositoryBase<Almacen>, IAlmacenRepository
    {
        public AlmacenRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
        public void AddHistoricoAlmacen( HistoricoAlmacen item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
      
        public void AddAlmacen(Almacen item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void DeleteAlmacen(Almacen item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

      
        public IEnumerable<Almacen> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Almacen where id like '%{0}%' or nombre like '%{0}%' ", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Almacen>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Almacen GetarticuloAlmacen(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Almacen where iditems like '{0}' ", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Almacen>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }
        public void UpdateAlmacen(Almacen item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void AddArticulo(Items item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Items> GetArticulo()
        {
            var query = new StringBuilder(string.Format("select * from Items order by Nombre asc"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Items>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Items GetArticuloNombreId()
        {
            var query = new StringBuilder(string.Format("select  max(id) as id from Items "));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Items>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }
        public IEnumerable<Items> GetArticuloNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Items where id like '%{0}%' or Nombre like '%{0}%' order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Items>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public void UpdateArticulo(Items item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void DeleteArticulo(Items item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Proveedor> GetProveedor()
        {
            var query = new StringBuilder(string.Format("select * from Proveedor"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Proveedor>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<Inventario> GetInventario()
        {
            var query = new StringBuilder(string.Format("select * from View_Inventario order by Articulo asc "));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Inventario>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<Inventario> GetInveNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from View_Inventario where id like '%{0}%' or Articulo like '%{0}%' order by Articulo asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Inventario>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Items GetItem(int Id)
        {
            var query = new StringBuilder(string.Format("select * from items where id= {0} ", Id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Items>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public void AddDetalle(DetalleItems entity)
        {
            var query = base.BuilderOfInsert(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void DeleteDetalle(int id)
        {
            var query = new StringBuilder(string.Format("delete DetalleItems where IdItems= {0} ", id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<DetalleItems> GetDetalleItems(int iditems)
        {
            var query = new StringBuilder(string.Format("select * from  DetalleItems where IdItems= {0} ", iditems));


            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<DetalleItems>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }
}
