using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é 18+");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não é 18+, mas está acompanhado");
                }
                else
                {
                    Console.WriteLine("João não é 18+");
                }
                
            }

            Console.ReadLine();
        }
    }
}
