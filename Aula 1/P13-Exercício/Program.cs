﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício sobre múltiplos de 3");

            for(int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
          
            Console.ReadLine();
        }
    }
}
