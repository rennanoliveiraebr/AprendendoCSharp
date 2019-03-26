using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3000.00;

            double taxa;
            int valor;

            if(salario >= 1900.00 && salario <= 2800.00)
            {
                taxa = 7.5;
                valor = 142;
                Console.WriteLine("A taxa é de: " + taxa + "%");
                Console.WriteLine("O valor é de: R$" + valor);
            }
            else if(salario >= 2800.01 && salario <= 3751.00)
            {
                taxa = 15;
                valor = 350;
                Console.WriteLine("A taxa é de: " + taxa + "%");
                Console.WriteLine("O valor é de: R$" + valor);
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                taxa = 22.5;
                valor = 636;
                Console.WriteLine("A taxa é de: " + taxa + "%");
                Console.WriteLine("O valor é de: R$" + valor);
            }

            Console.ReadLine();

        }
    }
}
