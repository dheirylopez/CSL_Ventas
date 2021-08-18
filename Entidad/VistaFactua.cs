using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.View_Factura")]
   public class VistaFactura
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdDetalle { get; set; }
        public string Articulo { get; set; }
        public string Empleado { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Itebis { get; set; }
        public decimal Descuento { get; set; }
        public decimal Precio { get; set; }
        public string NCF { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
