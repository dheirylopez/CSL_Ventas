using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Conduce")]
   public  class Conduce
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
    }
}
