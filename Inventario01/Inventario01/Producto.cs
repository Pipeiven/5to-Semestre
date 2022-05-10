using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario01
{
    internal class Producto
    {
        public Producto[] productos = new Producto[];   

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public string Linea { get; set; }

        public int Stock { get; }
    }

    public bool AgregarProducto(Producto p)
    {
        bool noExiste = true;
        
        for(int x = 0; x < productos.Length; x++)
        {
            if(productos[x] != null)
            {
                if (p.Descripcion == productos[x].Descripcion && p.Linea == productos[x].Linea)
                    noExiste = false;
            }
        }
        if (noExiste)
        {
            for(int x = productos.Length - 2; x >= 0; x--)
            {
                productos[x + 1] = productos[x];

            }
            productos[0] = p;  
        }
        return noExiste;
    }
}
