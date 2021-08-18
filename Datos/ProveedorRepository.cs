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
    public interface IProveedorRepository : IRepositoryBase<Proveedor>
        {
        IEnumerable<Proveedor> GetNombreId(string nombre);
        void AddProveedor(Proveedor item);
        void UpdateProveedor(Proveedor item);
        void DeleteProveedor(Proveedor item);
        Proveedor GetNombreId(int nombre);


    }
    public class ProveedorRepository : RepositoryBase<Proveedor>, IProveedorRepository
    {
        public ProveedorRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {

        }

        public void AddProveedor(Proveedor item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void DeleteProveedor(Proveedor item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Proveedor> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Proveedor where id like '%{0}%' or nombre like '%{0}%' or NDocumento like '%{0}%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Proveedor>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public Proveedor GetNombreId(int nombre)
        {
            var query = new StringBuilder(string.Format("select * from Proveedor where id like '%{0}%' ", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Proveedor>(query.ToString(), commandTimeout: CommandTimeout).First();
        }
        public void UpdateProveedor(Proveedor item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
    }
}
