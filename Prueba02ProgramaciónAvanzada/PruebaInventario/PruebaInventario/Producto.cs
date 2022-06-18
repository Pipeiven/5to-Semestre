using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInventario
{
    class Producto
    {

        public int ProdId { get; set; }

        public string ProdDescripcion { get; set; }

        public int ProdPropietario { get; set; }

        public int ProdValor { get; set; }

        public string Preferencia1 { get; set; }

        public string Preferencia2 { get; set; }

        public string Preferencia3 { get; set; }

        public Producto (int id, string descripcion, int propietario, int valor, string pref1, string pref2, string pref3)
        {
            ProdId = id;
            ProdDescripcion = descripcion;
            ProdPropietario = propietario;
            ProdValor = valor;
            Preferencia1 = pref1;
            Preferencia2 = pref2;
            Preferencia3 = pref3;

        }
    }
}
