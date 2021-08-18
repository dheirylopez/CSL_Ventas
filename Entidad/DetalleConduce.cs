using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.DetalleConduce")]
    public class DetalleConduce
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdConduce { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
     
    }

    public class DetalleConduceGrid
    {
        [Ignore, Identity]
        public int IdArticulo { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
      
    }

}
