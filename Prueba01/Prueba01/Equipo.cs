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
            for (int x = jugadores.Length - 2; x >= 0; x--)
            {
                if (jugador.Registro == jugadores[x].Registro)
                {
                    Console.WriteLine("Ya existe un jugador con el registro asociado.");
                    r = true;
                    break;
                }
            }
            if (r == true)
            {
                for (int x = jugadores.Length -2; x>= 0; x--)
                {
                    jugadores[x + 1] = jugadores[x];
                }
                jugadores[0] = jugador;
                Console.WriteLine("Se ha ingresado correctamente el jugador.");
            }
                    
        }

        public void EliminarJugador (int registro)
        {

        }

        public void BuscarJugador (string buscarJugador)
        {

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

        }

        public void CambiarJugador(int titular, int suplente)
        {

        }


        #endregion
    }
}
