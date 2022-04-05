using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class Tarjeta
    {
        public int NumeroTarjeta { get; set; }


        private int Saldo { get; set; }

        public string Vencimiento { get; set; }

        public string CodigoTarjeta { get; set; }

        public int Cupo { get; set; }

        public string Disponibilidad { get; set; }

        // Métodos

        public string EstadoCuenta { get; set; }

        public string Compra { get; set; }
    }
}
