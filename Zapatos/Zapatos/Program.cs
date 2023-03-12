using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos \n");
            Console.WriteLine("Opciones\n1-Comprar zapatos  \n2-Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Bienvenido...");
                    Tiendas tiendas = new Tiendas();
                    tiendas.Tienda();
                    Zapatos zapato = new Zapatos();
                    zapato.Zapatoss();
                    break;
                default:
                    Console.WriteLine("Lo siento");
                    break;
            }
        }
    }
}
