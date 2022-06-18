using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInventario
{
    class Inventario
    {
        public int InvId { get; set; }

        public int InvProducto { get; set; }

        public string InvFecha { get; set; }

        public int InvEntrada { get; set; }

        public int InvSalida { get; set; }

        public Inventario (int id, int prod, string fecha, int entrada, int salida) { 
            InvId = id; 
            InvProducto = prod; 
            InvFecha = fecha; 
            InvEntrada = entrada; 
            InvSalida = salida; 
        }
        

    }
}
