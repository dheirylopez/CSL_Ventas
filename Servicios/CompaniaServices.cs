using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface ICompaniaServices : ICommonOperationServices<Compania>
    {
        IEnumerable<Compania> GetNombreId(string nombre);
        Compania GetNombreId(int nombre);
        IEnumerable<Sucursal> Getidcompania(int nombre);
    }



    public class CompaniaServices : ICompaniaServices
    {
        private readonly ICompaniaRepository _companiaRepository = new CompaniaRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Compania> entities)
        {
            throw new NotImplementedException();
        }


        public void Add(Compania entity)
        {

            _companiaRepository.AddCompania(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Compania entity)
        {
            _companiaRepository.DeleteCompania(entity);
        }

        public IEnumerable<Compania> Get()
        {
            return _companiaRepository.Get();
        }
        public void Update(Compania entity)
        {
            _companiaRepository.UpdateCompania(entity);
        }


        public IEnumerable<Compania> GetNombreId(string nombre)
        {
           return _companiaRepository.GetNombreId(nombre);
        }

    

        public IEnumerable<Compania> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compania> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compania> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        Compania IServiceBase<Compania>.Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        Compania IServiceBase<Compania>.Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Compania GetNombreId(int nombre)
        {
            return _companiaRepository.GetNombreId(nombre);
        }

        public IEnumerable<Sucursal> Getidcompania(int nombre)
        {
            throw new NotImplementedException();
        }
    }
}
