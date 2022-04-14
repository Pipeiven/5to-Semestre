using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarjeta tc = new Tarjeta("Juanito");

            

            tc.Compra("Casino", -10000);
            tc.Abono("Efectivo", 100000);
            tc.Abono("Transferencia", 50000);
            tc.Cupo = 400000;
            tc.Compra("Cargo", 4000);
            tc.Compra("Notebook", 500000);
            tc.Cupo = 200000;


            Console.WriteLine("Estado de Cuenta \n" + tc.EstadoCuenta());

            Console.ReadKey();
        }
    }
}
