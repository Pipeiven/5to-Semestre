using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class Tarjeta
    {
        private Movimiento[] movimientos = new Movimiento[10];

        #region Propiedades
        public string NumeroTarjeta { get; set; }

        public string Nombre { get; set; }

        private int Saldo { get; set; }

        public string Vencimiento { get; set; }

        public string CodigoTarjeta { get; set; }

        public int Cupo { get; set; }

        public int Disponible {
            get
            {
                return Cupo + Saldo;
            }


                 }

        #endregion

        // Métodos

        #region Metodos

        public string EstadoCuenta() {


            return "";
        }

        public void Compra(string descripcion, int monto) {
            Movimiento m = new Movimiento();
            m.Tipo = 0;
            m.Descripcion = descripcion;
            m.Monto = monto;

            if (monto > 0)
                m.Monto = monto * -1;
            agregarMovimiento(m);

        }

        public void Abono(string descripcion, int monto){
            Movimiento m = new Movimiento();
            m.Tipo = 1;
            m.Descripcion = descripcion;
            m.Monto = monto;
            agregarMovimiento(m);
        }

        private void agregarMovimiento(Movimiento m)
        {
            for(int x = movimientos.Length - 2; x >= 0; x--)
            {
                movimientos[x + 1] = movimientos[x];
            }
            movimientos[0] = m;

            obtenerSaldo();

        }

        private void obtenerSaldo()
        {
            Saldo = 0;

            for (int x = 0; x < movimientos.Length - 1; x++){
                if (movimientos[x] != null)
                {
                    Saldo += movimientos[x].Monto;
                }
            }
        }

        #endregion
    }

}
