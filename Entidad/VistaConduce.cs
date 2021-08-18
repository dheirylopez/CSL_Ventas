using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.View_Conduce")]
    public class VistaConduce
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdConduce { get; set; }
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Empleado { get; set; }
        public int Cantidad { get; set; }
        public string Articulo { get; set; }
        public string Observacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
