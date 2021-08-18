using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.UsuarioSucursal")]
   public class UsuarioSucursal
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdUsuario{ get; set; }
        public int IdSucursal { get; set; }
    }
}
