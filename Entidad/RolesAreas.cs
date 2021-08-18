using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.RolesAreas")]
 public    class RolesAreas
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public int IdRol { get; set; }
        public int IdArea { get; set; }
    }
}
