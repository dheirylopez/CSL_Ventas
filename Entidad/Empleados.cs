using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("[dbo].[Empleado]")]
    public class Empleados
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoD { get; set; }
        public string NDocumento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Puesto { get; set; }
        public int Sueldo { get; set; }
    }
}
