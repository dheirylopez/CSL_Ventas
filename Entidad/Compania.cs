using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Compania")]
    public class Compania
    {
        [Ignore,Identity]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string TipoD { get; set; }
        public string NDoc { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}
