using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class Tarjeta
    {
        private Tarjeta[] tarjetas = new Tarjeta[1000];

        private Movimiento[] movimientos = new Movimiento[1000];

        Random rnd = new Random();

        #region Propiedades
        public string NumeroTarjeta { get;  }

        public string Nombre { get; }

        private int saldo_;
        private int Saldo { get; set; }

        public string Vencimiento { get; set; }

        private int codigoTarjeta_;
        public string CodigoTarjeta { get; set; }

        private int cupo_;
        public int Cupo
        {
            get { return cupo_; }
            set
            {
                int disponible = value + Saldo;
                if (value > 0 && disponible >= 0)
                {
                    cupo_ = value;
                }
            }
        }

        public int Disponible {
            get
            {
                return Cupo + Saldo;
            }


                 }

        public Tarjeta() { }

        public Tarjeta(string nombre)
        {
            Random rnd = new Random();

            Nombre = nombre;

            int num = rnd.Next(1000);
            NumeroTarjeta = rnd.Next(1000, 9999) + " - " + rnd.Next(1000, 9999)
                + " - " + rnd.Next(1000, 9999) + " - " + rnd.Next(1000, 9999);


        }

        public Tarjeta (string numeroTarjeta, string nombre, string saldo, string vencimiento, string codigoTarjeta, string cupo)
        {
            this.NumeroTarjeta = numeroTarjeta;
            this.Nombre = nombre;
            int.TryParse(saldo, out saldo_);
            this.Vencimiento = vencimiento;
            this.CodigoTarjeta = codigoTarjeta;
            //int.TryParse()  String.format("[%03d]", rnd.Next(1000));
            int.TryParse(cupo, out cupo_);
        }

        #endregion

        // Métodos

        #region Metodos

        public string EstadoCuenta() {
            string detalle = "";
            for(int x = tarjetas.Length -1; x>= 0; x--)
                if(movimientos[x] != null)
            {
                detalle += movimientos[x].DetalleCompleto() + "\n";
            }



            return detalle + "\n\n---------------------\n" + "Disponible = " + Disponible;
        }

        public void Compra(string descripcion, int monto) {
            Movimiento m = new Movimiento(1);
            m.Descripcion = descripcion;
            m.Monto = monto;

            if (monto > 0)
                m.Monto = monto * -1;
            agregarMovimiento(m);

        }

        public void Abono(string descripcion, int monto){
            Movimiento m = new Movimiento(0);
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
