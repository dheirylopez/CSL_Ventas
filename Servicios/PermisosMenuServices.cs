using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IPermisosMenuServices : ICommonOperationServices<PermisosMenu>
    {
        IEnumerable<PermisosMenu> GetNombreId(string nombre);

    }
    public class PermisosMenuServices : IPermisosMenuServices
    {
        private readonly IPermisosMenuRepository _PermisosMenuRepository = new PermisosMenuRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<PermisosMenu> entities)
        {
            throw new NotImplementedException();
        }


        public void Add(PermisosMenu entity)
        {

            _PermisosMenuRepository.AddPermisosMenu(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(PermisosMenu entity)
        {
            _PermisosMenuRepository.DeletePermisosMenu(entity);
        }

        public IEnumerable<PermisosMenu> Get()
        {

           
           

            return _PermisosMenuRepository.Get();
                
                
        }
        public void Update(PermisosMenu entity)
        {
            _PermisosMenuRepository.UpdatePermisosMenu(entity);
        }

        public IEnumerable<PermisosMenu> GetNombreId(string nombre)
        {
            return _PermisosMenuRepository.GetNombreId(nombre);
        }

        public PermisosMenu Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public PermisosMenu Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermisosMenu> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermisosMenu> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermisosMenu> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }
    }
}
