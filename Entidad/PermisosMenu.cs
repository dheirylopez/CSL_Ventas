using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.PermisoUsuario")]
    public class PermisosMenu
    {
        [Ignore, Identity]
        public int IdPermisoUsuario { get; set; }
        public int IdCompania { get; set; }
        public int IdUsuario { get; set; }
        public string Modulo { get; set; }
        public string PantallasMenu { get; set; }
        public string Permiso { get; set; }
        
    }
   }

