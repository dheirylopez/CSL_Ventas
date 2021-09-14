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
    public interface ISucursalRepository : IRepositoryBase<Sucursal>
    {
        void AddSucursal(Sucursal item);
        void UpdateSucursal(Sucursal item);
        void DeleteSucursal(Sucursal item);
        IEnumerable<Sucursal> GetNombreId(string nombre);
        Sucursal GetNombreId(int nombre);
        IEnumerable<Compania> Get(string nombre);
        IEnumerable<Compania> GetCompania();
        Compania Get(int nombre);
        IEnumerable<Sucursal> GetSucursalCompania(int nombre);
    }
    public class SucursalRepository : RepositoryBase<Sucursal>, ISucursalRepository
    {
        public SucursalRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {

        }
        public void DeleteSucursal(Sucursal item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void AddSucursal(Sucursal item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed ) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void UpdateSucursal(Sucursal item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Sucursal> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Sucursal where  nombre like '%{0}%' or NDocumento like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Sucursal>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public IEnumerable<Sucursal> GetSucursalCompania(int nombre)
        {
            var query = new StringBuilder(string.Format("select * from Sucursal where idcompania like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Sucursal>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public override IEnumerable<Sucursal> Get()
        {
            var query = new StringBuilder(string.Format("select * from Sucursal   order by Nombre asc"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Sucursal>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Sucursal GetNombreId(int nombre)
        {
            var query = new StringBuilder(string.Format("select * from Sucursal where  id like '%{0}%'   order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Sucursal>(query.ToString(), commandTimeout: CommandTimeout).First();
        }

        public IEnumerable<Compania> Get(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Compania where  nombre like '%{0}%' or NDocumento like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Compania>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public Compania Get(int nombre)
        {
            var query = new StringBuilder(string.Format("select * from Compania where  id like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Compania>(query.ToString(), commandTimeout: CommandTimeout).First();
        }
        public IEnumerable<Compania> GetCompania()
        {
            var query = new StringBuilder(string.Format("select * from Compania "));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Compania>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }
}
