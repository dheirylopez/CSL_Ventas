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
   public  interface ICompaniaRepository : IRepositoryBase<Compania>
    {
        void AddCompania(Compania item);
        void UpdateCompania(Compania item);
       void DeleteCompania(Compania item);
        IEnumerable<Compania> GetNombreId(string nombre);
        Compania GetNombreId(int nombre);
    }
    public class CompaniaRepository : RepositoryBase<Compania>, ICompaniaRepository
    {
        public CompaniaRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {

        }
        public void DeleteCompania(Compania item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void AddCompania(Compania item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed ) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void UpdateCompania(Compania item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Compania> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Compania where  nombre like '%{0}%' or NDocumento like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Compania>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public override IEnumerable<Compania> Get()
        {
            var query = new StringBuilder(string.Format("select * from Compania   order by Nombre asc"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Compania>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Compania GetNombreId(int nombre)
        {
            var query = new StringBuilder(string.Format("select * from Compania where  nombre like '%{0}%' or NDoc like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Compania>(query.ToString(), commandTimeout: CommandTimeout).First();
        }
    }
}
