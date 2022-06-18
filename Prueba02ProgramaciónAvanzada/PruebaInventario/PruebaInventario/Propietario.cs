using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInventario
{
    class Propietario
    {

        public int PropId { get; set; }

        public string PropNombre { get; set; }

        public string PropCorreo { get; set; }

        public Propietario (int id, string nombre, string correo)
        {
            PropId = id;
            PropNombre = nombre;
            PropCorreo = correo;
        }
    }
}
