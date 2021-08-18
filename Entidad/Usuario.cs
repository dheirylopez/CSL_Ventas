using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Usuario")]
    public class Usuario
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public string Clave { get; set; }
        public int Rol { get; set; }
        public int Estatus { get; set; }
    }
}
