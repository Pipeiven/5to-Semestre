using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente { Nombre = "Felipe", Edad = 33 };

            cli.Nombre = "Felipe";
            cli.Edad = 30;

            Console.ReadKey();
        }
    }
}
