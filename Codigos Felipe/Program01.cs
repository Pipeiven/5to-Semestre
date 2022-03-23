using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01Pav
{
    class Program
    {
        private static string nombre = "";
        private static string apellido = "";
        private static int edad = 0;
        private static string edadStr = "";

        static void Main(string[] args){

            try
            {
                Console.Write("Ingrese su nombre : ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su apellido : ");
                apellido = Console.ReadLine();
                Console.Write("Ingrese su edad : ");
                edadStr = Console.ReadLine();
                if (int.TryParse(edadStr, out edad)){
                    edad++;
                    if (nombre.Equals("Felipe", StringComparison.CurrentCultureIgnoreCase)){
                        Console.WriteLine("Bienvenido nuevamente al inframundo Felipe {0}, ya está pronto a cumplir {1} años", apellido, edad);
                    }
                    else{
                        Console.WriteLine("Bienvenido nuevamente al inframundo {0} {1}, ya está pronto a cumplir {2} años", nombre, apellido, edad);
                    }
                }else{
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor ingrese un número entero, inténtelo nuevamente");
                }
                
            }catch (FormatException ex){
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! ERROR DE INGRESO !!!");
            }
            catch (Exception ex){
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("!!! ERROR DE INGRESO !!!");
                Console.WriteLine(ex.ToString());

            }

            Console.ReadKey();


        }
    }
}
