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
   public  interface IEmpleadosRepository : IRepositoryBase<Empleados>
    {
        void AddEmpleados(Empleados item);
        void UpdateEmpleados(Empleados item);
       void DeleteEmpleados(Empleados item);
        IEnumerable<Empleados> GetNombreId(string nombre);
        Empleados GetNombreId(int id);
    }

    public class EmpleadosRepository : RepositoryBase<Empleados>, IEmpleadosRepository
    {
        public EmpleadosRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {

        }
        public void DeleteEmpleados(Empleados item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void AddEmpleados(Empleados item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed ) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void UpdateEmpleados(Empleados item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<Empleados> GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Empleado where  nombre like '%{0}%' or NDocumento like '%{0}%'  order by Nombre asc", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Empleados>(query.ToString(), commandTimeout: CommandTimeout);
        }
        public Empleados GetNombreId(int id)
        {
            var query = new StringBuilder(string.Format("select * from Empleado where  id like '%{0}%'  order by Nombre asc", id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Empleados>(query.ToString(), commandTimeout: CommandTimeout).First();
        }
        public override IEnumerable<Empleados> Get()
        {
            var query = new StringBuilder(string.Format("select * from Empleado order by Nombre asc"));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Empleados>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }
}
