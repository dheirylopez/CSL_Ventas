using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.NCF")]
    public  class NCF
    {
        [Ignore, Identity]
        public int id { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public int Estatus { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaUso { get; set; }
    }
}
