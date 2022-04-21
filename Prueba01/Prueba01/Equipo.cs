using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba01
{
    class Equipo
    {

        #region propiedades

        private Jugador[] jugadores = new Jugador[15];
        public string Id { get; set; }

        public string Nombre { get; set; }

        #endregion
        #region métodos

        public void AgregarJugador (Jugador jugador)
        {
            Boolean r = false;
            while (!r && jugador.Nombre != "")
            {
                for (int x = jugadores.Length - 1; x >= 0; x--)
                {
                    if (jugadores[x] != null)
                    {
                        if (jugador.Registro == jugadores[x].Registro)
                        {
                            Console.WriteLine("Ya existe un jugador con el registro asociado.");
                            Console.ReadKey();
                            r = true;

                        }
                    }
                }
                if (r == false)
                {
                    for (int x = jugadores.Length - 2; x >= 0; x--)
                    {
                        jugadores[x + 1] = jugadores[x];
                    }
                    jugadores[0] = jugador;
                    Console.WriteLine("Jugador agregado correctamente.");
                    Console.ReadKey();
                    r = true;
                }
            }
                    
        }

        public void EliminarJugador (int registro)
        {
            Jugador el = new Jugador();
            Boolean r = false;
            while (!r && registro.ToString() != "")
            {
                for (int x = jugadores.Length - 1; x >= 0; x--)
                {
                    if (jugadores[x] != null)
                    {
                        if (registro == jugadores[x].Registro)
                        {

                            jugadores[x] = el;
                            Console.WriteLine("Jugador Eliminado.");
                            Console.ReadKey();
                            r = true;

                        }
                    }
                }

            }



        }

        public void BuscarJugador(string buscarJugador)
        {

            Boolean r = false;
            while (!r && buscarJugador != "")
            {
                for (int x = jugadores.Length - 1; x >= 0; x--)
                {
                    if (jugadores[x] != null)
                    {
                        if (buscarJugador == jugadores[x].Nombre)
                        {
                            Console.WriteLine("Jugador Encontrado.");
                            Console.WriteLine(jugadores[x].DatosJugador());
                            Console.ReadKey();
                            r = true;

                        }
                        else
                        {
                            Console.WriteLine("Jugador no Encontrado");
                            r = true;
                        }
                    }
                }

            }
        }

        public string MostrarEquipoTitular()
        {
            return "";
        }

        public string MostrarEquipoSuplente()
        {
            return "";
        }

        public void BuscarJugador (int registroJugador)
        {
            Boolean r = false;
            while (!r && registroJugador.ToString() != "")
            {
                for (int x = jugadores.Length - 2; x >= 0; x--)
                {
                    if (jugadores[x] != null)
                    {
                        if (registroJugador == jugadores[x].Registro)
                        {
                            Console.WriteLine("Jugador Encontrado.");
                            Console.WriteLine(jugadores[x].DatosJugador());
                            Console.ReadKey();
                            r = true;


                        }
                        else
                        {
                            Console.WriteLine("Jugador no Encontrado");
                            r = true;
                        }
                    }
                }

            }
        }

        public void CambiarJugador(int titular, int suplente)
        {

        }


        #endregion
    }
}
