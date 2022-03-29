using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program02
{
    class Direccion{

        //TODO: Al menos 3 caracteres
        public string calle;
        public string Calle
        {
            get { return calle; }
            set
            {
                if (value.Length >= 3)
                {
                    calle = value;
                }
            }
        }

        //TODO: Sólo positivos

        public int numero;
        public int Numero
        {
            get { return numero; }
            set { if (value > 0){
                    numero = value;
                }
            }
        }

        //TODO: 
        public string Comuna { get; set; }

        //TODO: Atributo dirección calle.numero.comuna.tipo

        public string Tipo { get; set; }


        public string direccion;

        public Direccion(string calle, int numero, string comuna, string tipo)
        {
            this.Calle = calle;
            this.Numero = numero;
            this.Comuna = comuna;
            this.Tipo = tipo;
                       
        }

        public string DireccionCompleta
        {
            get { return Calle + " " + Numero + " " + Comuna + " " + Tipo + ""; }
        }
        
            
        }
    //("{0}.{1}.{2}.{3}", Calle, numero, Comuna, Tipo);
    }

