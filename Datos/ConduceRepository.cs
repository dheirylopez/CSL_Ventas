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
   public  interface IConduceRepository : IRepositoryBase<Conduce>
    {
        Conduce GetId();
        void AddDetalle(DetalleConduce entity);
        Factura GetNombreId(string nombre);
        IEnumerable<DetalleFactura> GetDetalleNombreId(string nombre);
        Items GetItem(int Id);
        IEnumerable<Conduce> GetIdConduce(string nombre);
        Clientes GetCliente(int Id);
        IEnumerable<DetalleConduce> GetDetalleConduece(string nombre);
        void AddConduce(Conduce item);
        void Update(Conduce item);
        void Delete(Conduce item);
        DetalleConduce GetArticulo(int idConsuce, int idArticulo);
        IEnumerable<VistaConduce> GetVistaConduce();
        IEnumerable<VistaConduce> GetNombreIdVistaC(string nombre);
    }
    public class ConduceRepository : RepositoryBase<Conduce>, IConduceRepository
    {
        public ConduceRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }

        public void AddConduce(Conduce item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void AddDetalle(DetalleConduce entity)
        {
            var query = base.BuilderOfInsert(entity);

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public Clientes GetCliente(int Id)
        {
            var query = new StringBuilder(string.Format("select * from cliente where id= {0} ", Id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Clientes>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public IEnumerable<DetalleFactura> GetDetalleNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from DetalleFactura where idFactura = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<DetalleFactura>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<DetalleConduce> GetDetalleConduece(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from DetalleConduce where idConduce = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<DetalleConduce>(query.ToString(), commandTimeout: CommandTimeout);
        }


        public Conduce GetId()
        {
            var query = new StringBuilder("select max(id) as id from conduce ");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Conduce>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public IEnumerable<Conduce> GetIdConduce(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from conduce where idfactura = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Conduce>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public Items GetItem(int Id)
        {
            var query = new StringBuilder(string.Format("select * from items where id= {0} ", Id));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Items>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public Factura GetNombreId(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from Factura where id = {0}", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Factura>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public DetalleConduce GetArticulo(int idConsuce, int idArticulo)
        {
            var query = new StringBuilder(string.Format("select * from DetalleConduce where idconduce = {0} and idArticulo ={1} ",idConsuce, idArticulo));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<DetalleConduce>(query.ToString(), commandTimeout: CommandTimeout).FirstOrDefault();
        }

        public IEnumerable<VistaConduce> GetVistaConduce()
        {
            var query = new StringBuilder(string.Format("select * from View_Conduce  "));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaConduce>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public IEnumerable<VistaConduce> GetNombreIdVistaC(string nombre)
        {
            var query = new StringBuilder(string.Format("select * from View_Conduce where idConduce like '%{0}%'or  IdFactura like '%{0}%'  or Empleado like '%{0}%'", nombre));

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<VistaConduce>(query.ToString(), commandTimeout: CommandTimeout);
        }
    }
}
