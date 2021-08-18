using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Cliente")]
    public class Clientes
    {
        [Ignore,Identity]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string TipoD { get; set; }
        public string NDocumento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}
