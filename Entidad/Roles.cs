using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Roles")]
    public class Roles
    {
        [Ignore, Identity]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
