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
    public interface iSeguridadRepository : IRepositoryBase<Empleados>
    {
        Usuario GetUsuaario(int id);
        Empleados GetEmpleado(int id);
        IEnumerable<Roles> GetRol();
        void AddRol(Roles entity);
        void UpdateRol(Roles entity);
        void DeleteRol(Roles entity);
        IEnumerable<Roles> GetNombreId(string nombre);
        void AddEmpleados(Empleados entity);
        void Update(Empleados entity);
        void Delete(Empleados entity);
        IEnumerable<Empleados> GetNombreIdEmpleado(string nombre);
        IEnumerable<Empleados> GetEmpleado();
     
    }
        public class SeguridadRepository : RepositoryBase<Empleados>, iSeguridadRepository
    {
        public SeguridadRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }

        public void AddRol(Roles entity)
        {
            var query = base.BuilderOfInsert(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void DeleteRol(Roles entity)
        {
            var query = base.BuilderOfDelete(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public Empleados GetEmpleado(int id)
        {
            var query = new StringBuilder("Select * From  Empleado ");
            query.AppendFormat(" Where id = {0}", id);
            return DbConnection.Query<Empleados>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public override  IEnumerable<Empleados> Get()
        {
            var query = new StringBuilder("select * from [dbo].[Empleado] inner join usuario u on[dbo].[Empleado].id = u.IdEmpleado ");

         
            return DbConnection.Query<Empleados>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public IEnumerable<Roles> GetRol()
        {
            var query = new StringBuilder("Select * From  Roles");
          
            return DbConnection.Query<Roles>(query.ToString(), commandTimeout: CommandTimeout);

        }

        public Usuario GetUsuaario(int id)
        {
            var query = new StringBuilder("Select * From  Usuario");
            query.AppendFormat(" Where idEmpleado = {0}", id);
            return DbConnection.Query<Usuario>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
           
        }
        public IEnumerable<Roles> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Roles where id like '%{0}%' or Nombre like '%{0}%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Roles>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public void UpdateRol(Roles entity)
        {
            var query = base.BuilderOfUpdate(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void AddEmpleados(Empleados entity)
        {
            var query = base.BuilderOfInsert(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Empleados> GetNombreIdEmpleado(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Empleado where id like '%{0}%' or Nombre like '%{0}%' or NDocumento like '%{0}%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Empleados>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public IEnumerable<UsuarioCompania> GetCompaniaUsuario(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from UsuarioCompania where idusuario like '%{0}%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<UsuarioCompania>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public IEnumerable<Empleados> GetEmpleado()
        {
            var query = new StringBuilder(string.Format("select * from Empleado "));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Empleados>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }


    public interface iUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario GetUsuaario(int id);
        void Add(Usuario item);
        void Update(Usuario item);
        IEnumerable<UsuarioCompania> GetUsuarioCompania(int nombre);
    }

    public class UsuarioRepository : RepositoryBase<Usuario>, iUsuarioRepository
    {
        public UsuarioRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }

        public new void Add(Usuario item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public new void Update(Usuario item)
        {
            
            var query = base.BuilderOfUpdate(item);
                

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public Usuario GetUsuaario(int id)
        {
            var query = new StringBuilder("Select * From  Usuario");
            query.AppendFormat(" Where idEmpleado = {0}", id);
            return DbConnection.Query<Usuario>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();

        }

        public IEnumerable<UsuarioCompania> GetUsuarioCompania(int nombre)
        {
            var query = new StringBuilder(string.Format("select * from UsuarioCompania where idusuario like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<UsuarioCompania>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }
}
