using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapatos
{
    internal class Tiendas
    {
        public string tipo;

        public void Tienda()
        {
           
            Console.WriteLine("Seleccione la tienda en la cual desea comprar: \n1-MD \n2-PAR DOS \n3-SIMAN \n4-ADOC \n5-HUSH PUPPIES");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "MD";
                    break;
                case 2:
                    tipo = "PAR DOS";
                    break;
                case 3:
                    tipo = "SIMAN";
                    break;
                case 4:
                    tipo = "ADOC";
                    break;
                case 5:
                    tipo = "HUSH PUPPIES";
                    break;
                default:
                    break;
            }
        }
      
    }
}
