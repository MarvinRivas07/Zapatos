﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapatos
{
    internal class Marca
    {
        public string tipo;
        public void zapatosVestir()
        {

            Console.WriteLine("Que tipo de zapatos desea:: \n1-Zapatos  \n2-Deportivos \n3-Zapatos Para Dama \n4-Zapatos Para Niños");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "Zapatos De Vestir";
                    break;
                case 2:
                    tipo = "Deportivos";
                    break;
                case 3:
                    tipo = "Zapatos Para Dama";
                    break;
                case 4:
                    tipo = "Zapatos Para Niños";
                    break;
                default:
                    break;
            }
        }

    }
}