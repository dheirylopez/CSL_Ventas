using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.UsuarioCompania")]
   public class UsuarioCompania
    {
        [Ignore, Identity]
        public int Id { get; set; }
         public int IdUsuario { get; set; } 
        public int IdCompania { get; set; }
        public string Nombre { get; set; }

    }
}
