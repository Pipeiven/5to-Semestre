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
                int idProd, idPropietario, idInv, invEntrada, invSalida, prValor;
                bool firstLane = false;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('|');

                    if (firstLane)
                    {

                        int.TryParse(values[0], out idProd);
                        int.TryParse(values[2], out prValor);
                        int.TryParse(values[7], out idPropietario);
                        int.TryParse(values[9], out idInv);
                        int.TryParse(values[11], out invEntrada);
                        int.TryParse(values[12], out invSalida);


                        inventario.Add(new Inventario(idInv, idProd, values[10], invEntrada, invSalida));
                        propietarios.Add(new Propietario(idPropietario, values[6], values[8]));
                        productos.Add(new Producto(idProd, values[1], idPropietario, prValor, values[3], values[4], values[5]));
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
                Console.WriteLine("ID: {0}, Descripción: {1}, Propietario: {2}, Valor: {3} pesos, Preferencia01: {4}, Preferencia02: {5}, Preferencia03: {6}", p.ProdId, p.ProdDescripcion, p.ProdPropietario, p.ProdValor, p.Preferencia1, p.Preferencia2, p.Preferencia3);
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