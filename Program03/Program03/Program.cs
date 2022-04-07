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
            Tarjeta tc = new Tarjeta();

            tc.Cupo = 200000;

            tc.Compra("Casino", -10000);
            tc.Abono("Efectivo", 100000);
            tc.Abono("Transferencia", 50000);
            tc.Compra("Cargo", 4000);
            

            Console.ReadKey();
        }
    }
}
