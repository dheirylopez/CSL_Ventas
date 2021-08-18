using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.DetalleFactura")]
   public  class DetalleFactura
    {
        [Ignore,Identity]
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public float PrecioU { get; set; }
        public float Itebi { get; set; }
    }

    public class DetalleFacturaGrid
    {
        [Ignore, Identity]
 
 
        public int IdArticulo { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public double PrecioU { get; set; }
        public double Itebis { get; set; }
        
    }
}
