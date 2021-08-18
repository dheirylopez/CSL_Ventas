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
    public interface INCFRepository : IRepositoryBase<NCF>
    {
        void Add(NCF item);
        void Update(NCF item);
        void Delete(NCF item);
    }
    public class NCFRepository : RepositoryBase<NCF>, INCFRepository
    {
        public NCFRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }

        void INCFRepository.Add(NCF item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        void INCFRepository.Update(NCF item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        void INCFRepository.Delete(NCF item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
    }
}
