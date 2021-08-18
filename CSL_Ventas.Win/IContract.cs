using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSL_Ventas.Win
{
  public  interface IContract
    {
        void Ejecutar(Inventario informacion);
        void Ejecutar(Clientes informacion);
        void Ejecutar(Items informacion);
    }
}
