using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapatos
{
    internal class Marca
    {
        public string tipo;
        public string marca;
        public string talla;
        public void zapatosVestir()
        {
            Console.WriteLine("BIENVENID@ A LA SECCION DE ZAPATOS PARA CABALLERO");

            Console.WriteLine("Que tipo de zapatos desea: \n1-Zapato Adam James \nMARCA: NIKE \nTALLA: 32  \n2-Zapato Tempra Oxford \nMARCA: ADIDAS\nTALLA: 39 " +
                "\n3-Tenis Jean Oxford \nMARCA: ADIDAS\nTALLA: 34");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Zapato Adam James";
                    marca = "NIKE";
                    talla = "32";
                    break;
                case 2:
                    tipo = "Zapato Tempra Oxford";
                    marca = "ADIDAS";
                    talla = "39";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos que seleccionaste tienen un 25% de descuento");
                    break;
                case 3:
                    tipo = "Tenis Jean Oxford";
                    marca = "ADIDAS";
                    talla = "34";
                    break;
                default:
                    break;
            }


        }
        public void zapatosDesportivos()
        {
            Console.WriteLine("BIENVENID@ A LA SECCION DE ZAPATOS DEPORTIVOS");

            Console.WriteLine("Que tipo de zapatos desea: \n1-Under Armour\nMARCA: Under Armour \nTALLA: 34  \n2-Brooks Adrenaline GTS 22 \nMARCA: PUMA\nTALLA: 40 " +
                "\n3-New Balance \nMARCA: NB \nTALLA: 32");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Under Armour";
                    marca = "Under Armour";
                    talla = "34";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos que seleccionaste tienen un 10% de descuento" );
                    break;
                case 2:
                    tipo = "Brooks Adrenaline GTS 22";
                    marca = "PUMA";
                    talla = "40";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos que seleccionaste tienen un 7% de descuento");
                    break;
                case 3:
                    tipo = "New Balance";
                    marca = "NB";
                    talla = "32";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos que seleccionaste tienen un 9% de descuento");
                    break;
                default:
                    break;
            }


        }
        public void zapatoParaDama()
        {
            Console.WriteLine("BIENVENID@ A LA SECCION DE ZAPATOS DEPORTIVOS");

            Console.WriteLine("Que tipo de zapatos desea: \n1-Zapatos de tacon semi abiertos\nMARCA: SODA \nTALLA: 28  \n2-Sandalias flast blancas \nMARCA: MOLECA\nTALLA: 32 " +
                "\n3-Sandalias de plataforma cafés\nMARCA: JESSICA CARLYLE \nTALLA: 30");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Zapatos de tacon semi abiertos";
                    marca = "SODA";
                    talla = "28";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos que seleccionaste tienen un 30% de descuento");
                    break;
                case 2:
                    tipo = "Sandalias flast blancas";
                    marca = "MOLECA";
                    talla = "32";
                    break;
                case 3:
                    tipo = "Sandalias de plataforma cafés";
                    marca = "JESSICA CARLYLE";
                    talla = "30";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos que seleccionaste tienen un 10% de descuento");
                    break;
                default:
                    break;
            }


        }
        public void zapatoParaNiño()
        {
            Console.WriteLine("BIENVENID@ A LA SECCION DE ZAPATOS DEPORTIVOS");

            Console.WriteLine("Que tipo de zapatos desea: \n1-Nike Air Max 90 LTR\nMARCA: NIKE \nTALLA: 22  \n2-Adidas Racer \nMARCA: ADIDAS\nTALLA: 2O " +
                "\n3-Fresh Foam Roav\nMARCA: NEW BALANCE \nTALLA: 20");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Nike Air Max 90 LTR";
                    marca = "NIKE";
                    talla = "22";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos que seleccionaste tienen un 8% de descuento");
                    break;
                case 2:
                    tipo = "Adidas Racer";
                    marca = "ADIDAS";
                    talla = "20";
                    break;
                case 3:
                    tipo = "Fresh Foam Roav";
                    marca = "NEW BALANCE";
                    talla = "20";
                    Console.WriteLine("FELICIDADES!!!!!!!!!!! \n Los zapatos" + tipo + "que seleccionaste tienen un 9% de descuento");
                    break;
                default:
                    break;
            }


        }

    }
}
