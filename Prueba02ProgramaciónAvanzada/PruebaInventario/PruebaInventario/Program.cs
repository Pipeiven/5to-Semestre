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

            Console.WriteLine("Ingrese el ID del Movimiento que desea ver");

            bool a = int.TryParse(Console.ReadLine(), out int b);

            InventarioController.mostrarInventario(b);

            Console.ReadLine();

            InventarioController.mostrarInventario();

            InventarioController.mostrarProductos();

            InventarioController.mostrarPropietarios();

            Console.ReadLine();
        }
    }
}
