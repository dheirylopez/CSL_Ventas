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
   public  interface IClienteRepository : IRepositoryBase<Clientes>
    {
        void AddCliente(Clientes item);
        void UpdateCliente(Clientes item);
       void  DeleteCliente(Clientes item);
        IEnumerable<Clientes> GetNombreId(string nombre);
        Clientes GetNombreId(int nombre);
    }
    public class ClienteRepository : RepositoryBase<Clientes>, IClienteRepository
    {
        public ClienteRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {

        }
        public void DeleteCliente(Clientes item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void AddCliente(Clientes item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed ) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void UpdateCliente(Clientes item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Clientes> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Cliente where  nombre like '%{0}%' or NDocumento like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Clientes>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public override IEnumerable<Clientes> Get()
        {
            var query = new StringBuilder(string.Format("select * from Cliente   order by Nombre asc"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Clientes>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Clientes GetNombreId(int nombre)
        {
            var query = new StringBuilder(string.Format("select * from Cliente where  id like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Clientes>(query.ToString(), commandTimeout: CommandTimeout).First();
        }
    }
}
