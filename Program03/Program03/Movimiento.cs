using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class Movimiento
    {
        public int Tipo { get; }

        public int Monto { get; set; }

        public string Descripcion { get; set; }

        public string Fecha { get;}

        public string Transaccion { get;}

        public string DetalleCompleto()
        {
            string tipo = "";
            if (Tipo.Equals(1))
                tipo = "Cargo";
            else
                tipo = "Abono";
            return tipo + " - " + Fecha + " - " + Transaccion + " - " + Descripcion + " - " + Monto;
        }

        public Movimiento(int tipo)
        {
            Guid transaccion = Guid.NewGuid();
            Transaccion = transaccion.ToString();
            //Console.WriteLine(transaccion.ToString());
            //Console.WriteLine(DateTime.Now.ToString());
            Fecha = DateTime.Now.ToString();
            Tipo = tipo;
        }
    }
}
