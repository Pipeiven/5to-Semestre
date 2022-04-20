using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba01
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo eq = new Equipo();

            
            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.WriteLine("MENU EQUIPO FUTBOL SITO MAN BOY");
                    Console.WriteLine("");
                    Console.WriteLine("1 = Agregar Jugador");
                    Console.WriteLine("2 = Eliminar Jugador");
                    Console.WriteLine("3 = Buscar Jugador");
                    Console.WriteLine("4 = Mostrar Equipo");
                    Console.WriteLine("5 = Cambiar de Titular a Suplente");
                    Console.WriteLine("6 = Salir");
                    Console.WriteLine("");

                    Console.WriteLine("Ingrese la opción que desee ejecutar:");
                    int.TryParse(Console.ReadLine(), out int o);
                    switch (o)
                    {
                        case 1:

                            Console.WriteLine("Ingrese el Nombre del Jugador que desea agregar.");
                            Jugador jg = new Jugador(Console.ReadLine());
                            eq.AgregarJugador(jg);
                            break;

                        case 2:

                            break;

                        case 3:

                            break;

                        case 4:

                            break;

                        case 5:

                            break;

                        case 6:
                            salir = true;
                            break;

                        default:

                            break;


                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            
        }
    }
}
