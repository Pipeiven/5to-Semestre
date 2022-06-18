using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInventario
{
    class Program
    {
        static void Main(string[] args)
        {

            InventarioController.almacenarCSV();

            InventarioController.mostrarInventario();

            InventarioController.mostrarProductos();

            InventarioController.mostrarPropietarios();

            Console.ReadLine();
        }
    }
}
