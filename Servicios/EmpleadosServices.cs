using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IEmpleadosServices : ICommonOperationServices<Empleados>
    {
        IEnumerable<Empleados> GetNombreId(string nombre);
        Empleados GetNombreId(int nombre);
      
    }



    public class EmpleadosServices : IEmpleadosServices
    {
        private readonly IEmpleadosRepository _empleadosRepository = new EmpleadosRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Empleados> entities)
        {
            throw new NotImplementedException();
        }


        public void Add(Empleados entity)
        {

            _empleadosRepository.AddEmpleados(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Empleados entity)
        {
            _empleadosRepository.DeleteEmpleados(entity);
        }

        public IEnumerable<Empleados> Get()
        {
            return _empleadosRepository.Get();
        }
        public void Update(Empleados entity)
        {
            _empleadosRepository.UpdateEmpleados(entity);
        }


        public IEnumerable<Empleados> GetNombreId(string nombre)
        {
            return _empleadosRepository.GetNombreId(nombre);
        }

        public Empleados Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public Empleados Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleados> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleados> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleados> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public Empleados GetNombreId(int nombre)
        {
            return _empleadosRepository.GetNombreId(nombre);
        }
    }
}
