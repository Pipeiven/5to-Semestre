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
        public int Registro { get; set; }

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
            Nombre = nombre;

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