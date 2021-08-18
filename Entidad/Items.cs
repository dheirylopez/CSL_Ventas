using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Items")]
   public class Items
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
    }
    public class DetalleItems
    {
        [Ignore, Identity]
        public int IdDetalle { get; set; }
        public int IdItems { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
    }
}
