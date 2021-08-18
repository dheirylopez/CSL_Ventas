using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.HistoricoAlmacen")]
    public class HistoricoAlmacen
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdAlmacen { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
    }
}
