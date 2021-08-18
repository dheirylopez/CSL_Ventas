using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.View_Cotizacion")]
  public  class VistaCotizacion
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdDetalle { get; set; }
        public string Articulo { get; set; }
        public string Colaborador { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
        public int SubTotal { get; set; }
        public int Itebis { get; set; }
        public int Descuento { get; set; }
        public int Precio { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }

    }
}
