using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Cotizacion")]
    public  class Cotizacion
    {
        [Ignore,Identity]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public int Descuento { get; set; }
        public int SubTotal { get; set; }
        public int Itebis { get; set; }
        public int Total { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public int Estatus { get; set; }
    }
}
