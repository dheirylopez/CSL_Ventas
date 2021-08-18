using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.CierreDia")]
    public class Cierre
    {

        [Ignore, Identity]
        public int Id { get; set; }
        public int Colaborador { get; set; }
        public int Monto_Inicial_Caja { get; set; }
        public double Total_Facturado { get; set; }

        public double Total_Pagado { get; set; }
        public double Total_Pendiente { get; set; }
        public int IdCaja { get; set; }
     
        public int Estatus { get; set; }
        public DateTime Fecha { get; set; }

    }
}
