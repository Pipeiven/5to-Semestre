using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program02
{
    class Cliente
    {
        public string Nombre {
            get;
            set;
        }
        private int edad_;

        public int Edad {
            get { return edad_; }
            set { if (value >= 0) {
                    edad_ = value;
                } }
        }

        public Direccion[] Direcciones = new Direccion[10];
        public Cliente(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public Cliente(string nombre, string edad)
        {
            this.Nombre = nombre;
            int.TryParse(edad, out edad_);
        }

        public Cliente() { }
    }
}
