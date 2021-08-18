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
   
        public interface IPermisosMenuRepository: IRepositoryBase<PermisosMenu>
        {
            void AddPermisosMenu(PermisosMenu item);
            void UpdatePermisosMenu(PermisosMenu item);
            void DeletePermisosMenu(PermisosMenu item);
            IEnumerable<PermisosMenu> GetNombreId(string nombre);
        }
        public class PermisosMenuRepository : RepositoryBase<PermisosMenu>, IPermisosMenuRepository
        {
            public PermisosMenuRepository(DbConnectionObj dbConnection) : base(dbConnection)
            {

            }

        public void DeletePermisosMenu(PermisosMenu item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void AddPermisosMenu(PermisosMenu item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void UpdatePermisosMenu(PermisosMenu item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<PermisosMenu> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select*from dbo.PermisoUsuario where Idusuario={0} and nombre like '%menu%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<PermisosMenu>(query.ToString(), commandTimeout: CommandTimeout);
        }

    }

}
