using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInventario
{
    class InventarioController
    {private static List<Inventario> inventario = new List<Inventario>();
       private static List<Propietario> propietarios = new List<Propietario>();
       private static List<Producto> productos = new List<Producto>();

        public static void almacenarCSV()
        {
            using (var reader = new StreamReader("C:/Users/felip/OneDrive/Escritorio/Prueba02ProgramaciónAvanzada/PruebaInventario/PruebaInventario/Historico.csv"))
            {
                int idProd, idPropietario, idInv, invEntrada, invSalida;
                bool firstLane = false;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('|');

                    if (firstLane)
                    {

                        int.TryParse(values[0], out idProd);
                        int.TryParse(values[6], out idPropietario);
                        int.TryParse(values[8], out idInv);
                        int.TryParse(values[10], out invEntrada);
                        int.TryParse(values[11], out invSalida);


                        inventario.Add(new Inventario(idInv, idProd, values[9], invEntrada, invSalida));
                        propietarios.Add(new Propietario(idPropietario, values[5], values[7]));
                        productos.Add(new Producto(idProd, values[1], idPropietario, values[2], values[3], values[4]));
                    }
                    else
                    {
                        firstLane = true;
                    }
                }
            }
        }
        public static void mostrarInventario(int i)
        {
            foreach (Inventario a in inventario)
            {
                if (a.InvId == i)
                Console.WriteLine("Folio: {0}, Producto: {1}, Fecha: {2}, Entrada: {3}, Salida: {4}", a.InvId, a.InvProducto, a.InvFecha, a.InvEntrada, a.InvSalida);
            }
        }

        public static void mostrarInventario()
        {
            IEnumerable<Inventario> inventarios = from i in inventario orderby i.InvId descending select i;

            foreach (Inventario a in inventarios)
            {
                Console.WriteLine("Folio: {0}, Producto: {1}, Fecha: {2}, Entrada: {3}, Salida: {4}", a.InvId, a.InvProducto, a.InvFecha, a.InvEntrada, a.InvSalida); 
            }
        }

        public static void mostrarProductos()
        {
            IEnumerable<Producto> producto = from p in productos orderby p.ProdId select p;

            foreach (Producto p in productos)
            {
                Console.WriteLine("ID: {0}, Descripción: {1}, Propietario: {2}, Preferencia01: {3}, Preferencia02: {4}, Preferencia03: {5}", p.ProdId, p.ProdDescripcion, p.ProdPropietario, p.Preferencia1, p.Preferencia2, p.Preferencia3);
            }
        }

        public static void mostrarPropietarios()
        {
            IEnumerable<Propietario> propietario = from pr in propietarios orderby pr.PropId select pr;

            foreach (Propietario pr in propietarios)
            {
                Console.WriteLine("ID: {0}, Nombre: {1}, Correo: {2}", pr.PropId, pr.PropNombre, pr.PropCorreo);
            }
        }
    }
}
