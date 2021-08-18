using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Factura")]
    public class Factura
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public double Descuento { get; set; }
        public double SubTotal { get; set; }
        public double Itebis { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public string NCF { get; set; }
        public string Observacion { get; set; }
        public int Estatus { get; set; }
        public string Tipo_NCF { get; set; }
        public double Pago_Inicial { get; set; }
        public double Pago_Pendiente { get; set; }
        public string Tipo_Factura { get; set; }
        public string Forma_Pago { get; set; }
        public double MontoPagado { get; set; }
        public double Cambio { get; set; }

    }
}
