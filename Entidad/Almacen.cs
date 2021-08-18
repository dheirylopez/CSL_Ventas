using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Almacen")]
    public class Almacen
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdItems { get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }
        public int Cantidad { get; set; }
        public string PrecioC { get; set; }
        public string PrecioV { get; set; }
        public DateTime Fecha { get; set; }

    }
    [TableName("dbo.View_Inventario")]
    public class Inventario
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public string Articulo { get; set; }
        public string Colaborador { get; set; }
        public string Proveedor { get; set; }
        public int Cantidad { get; set; }
        public double PrecioC { get; set; }
        public double PrecioV { get; set; }
        public DateTime Fecha { get; set; }

    }
    [TableName("dbo.caja")]
    public class caja
    {
        [Ignore, Identity]
        public int Id { get; set; }
       
        public string dinerocaja{ get; set; }
      
        public DateTime Fecha { get; set; }

    }
}
