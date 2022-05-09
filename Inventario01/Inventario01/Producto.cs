using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario01
{
    internal class Producto
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public string Linea { get; set; }

        public int Stock { get; }
    }
}
