using Edeeste.IRepository.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [TableName("dbo.Sucursal")]
    public class Sucursal
    {
        [Ignore,Identity]
        public int Id { get; set; }
        public string Nombre { get; set; }
       
        public int Compania { get; set; }
        public string RNL { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    
    }
}
