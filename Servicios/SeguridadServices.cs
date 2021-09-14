using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface ISeguridadServices : ICommonOperationServices<Empleados>
    {
        bool Validar(int id, string clave);
        Empleados GetEmpleado(int id);
        Usuario GetUsuaario(int id);
        IEnumerable<Roles> GetRol();
        void AddUsuario(Usuario entity);
        void UpdateUsuario(Usuario entity);
        void AddRol(Roles entity);
        void UpdateRol(Roles entity);
        void DeleteRol(Roles entity);
        IEnumerable<Roles> GetNombreId(string nombre);
        IEnumerable<Empleados> GetNombreIdEmpleado(string nombre);
        IEnumerable<Sucursal> GetSucursalesCompania(int nombre);
        IEnumerable<UsuarioCompania> GetUsuarioCompania(int nombre);
    }
    public class SeguridadServices : ISeguridadServices
    {
        readonly iSeguridadRepository _seguridadRepository = new SeguridadRepository(Conexion.GetDbConnectionSQL());
        readonly iUsuarioRepository _usuarioRepository = new UsuarioRepository(Conexion.GetDbConnectionSQL());
        readonly ISucursalRepository _sucursalRepository = new SucursalRepository(Conexion.GetDbConnectionSQL());
        public void Add(IEnumerable<Empleados> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Empleados entity)
        {
            _seguridadRepository.AddEmpleados(entity);
        }

        public void AddRol(Roles entity)
        {
            _seguridadRepository.AddRol(entity);
        }

        public void AddUsuario(Usuario entity)
        {

            _usuarioRepository.Add(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Empleados entity)
        {
            _seguridadRepository.Delete(entity);
        }

        public void DeleteRol(Roles entity)
        {
            _seguridadRepository.DeleteRol(entity);
        }

        public IEnumerable<Empleados> Get()
        {
            return _seguridadRepository.Get();
        }
        public IEnumerable<Sucursal> GetSucursalesCompania(int nombre)
        {
            return _sucursalRepository.GetSucursalCompania(nombre);
        }
        public Empleados Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Empleados Get(KeyValuePair<string, int> value)
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

        public Empleados GetEmpleado(int id)
        {
            return _seguridadRepository.GetEmpleado(id);

        }

        public IEnumerable<Empleados> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleados> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Roles> GetNombreId(string nombre)
        {
            return _seguridadRepository.GetNombreId(nombre);
        }
        public IEnumerable<Empleados> GetNombreIdEmpleado(string nombre)
        {
            return _seguridadRepository.GetNombreIdEmpleado(nombre);
        }
        public IEnumerable<Roles> GetRol()
        {
            return _seguridadRepository.GetRol();
        }

        public Usuario GetUsuaario(int id)
        {
            return _seguridadRepository.GetUsuaario(id);
        }

        public void Update(Empleados entity)
        {
            _seguridadRepository.Update(entity);
        }

        public void UpdateRol(Roles entity)
        {
            _seguridadRepository.UpdateRol(entity);
        }

        public void UpdateUsuario(Usuario entity)
        {
            _usuarioRepository.Update(entity);
        }

        public bool Validar(int id, string clave)
        {

            var usuario = _seguridadRepository.GetUsuaario(id);
            var varlor = false;
            if (usuario != null)
            {
                if (usuario.IdEmpleado == id && usuario.Clave.ToString() == clave && usuario.Estatus == 1)
                {
                    varlor = true;
                }

            }
            return varlor;
        }

        public IEnumerable<UsuarioCompania> GetUsuarioCompania(int nombre)
        {
            return _usuarioRepository.GetUsuarioCompania(nombre);
        }

       
    }
}
