using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba01
{
    class Jugador
    {

        #region propiedades

        public int registro_;
        public int Registro
        {
            get { return registro_; }
            set
            {
                if (value > 0)
                {
                    registro_ = value;
                }
            }
        }

        public string Nombre { get; set; }

        public string Posicion { get; set; }

        public int Resistencia { get; set; }

        public int Velocidad { get; set; }

        public int Fuerza { get; set; }

        public int Destreza { get; set; }

        public Jugador()
        {

        }

        public Jugador(string nombre)
        {
            string posicion;
            int counter = 0;
            int resistencia;
            int velocidad;
            int fuerza;
            int destreza;
            Boolean r = false;
            

            while (!r)
            {
                Console.WriteLine("Ingrese la Posición del Jugador.");
                posicion = Console.ReadLine();
                if (posicion.ToUpper() == "PORTERO")
                {
                    Posicion = "Portero";
                }
                else if (posicion.ToUpper() == "DEFENSA")
                {
                    Posicion = "Defensa";
                }
                else if (posicion.ToUpper() == "MEDIO CAMPO")
                {
                    Posicion = "Medio Campo";
                }
                else if (posicion.ToUpper() == "DELANTERO")
                {
                    Posicion = "Delantero";
                }
                else
                {
                    Console.WriteLine("No existe dicha posición.");
                    Console.ReadKey();
                    Nombre = "";
                    r = true;
                    break;
                }
                while (counter <= 100)
                {
                    Console.WriteLine("Ingrese las habilidades del jugador. \n " +
                        "(Recuerde que la suma de éstas no debe superar los 100 puntos)");
                    Console.WriteLine("Resistencia:");
                    int.TryParse(Console.ReadLine(), out resistencia);
                    counter = resistencia;
                    Console.WriteLine("Velocidad:");
                    int.TryParse(Console.ReadLine(), out velocidad);
                    counter += velocidad;
                    Console.WriteLine("Fuerza:");
                    int.TryParse(Console.ReadLine(), out fuerza);
                    counter += fuerza;
                    Console.WriteLine("Destreza:");
                    int.TryParse(Console.ReadLine(), out destreza);
                    counter += destreza;
                    Resistencia = resistencia;
                    Velocidad = velocidad;
                    Fuerza = fuerza;
                    Destreza = destreza;

                    Random rnd = new Random();
                    Registro = rnd.Next(10000000);
                    Nombre = nombre;
                    r = true;
                    break;                    
                }
                if (counter > 100)
                {
                    Console.WriteLine("La suma de puntos ha superado 100");
                    Console.ReadKey();
                    Nombre = "";
                    r = true;
                }
            }
            
                
                
            
        }
        #endregion

        #region métodos

        public string DatosJugador()
        {
            return Posicion + ", " + Nombre + ", Resistencia:" + Resistencia +
                ", Velocidad:" + Velocidad + ", Fuerza:" + ", Destreza:" + Destreza;

        }

        #endregion

    }
}