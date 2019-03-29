using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Praticando Classes");

            ModeloRoupa pedidoUm = new ModeloRoupa();

            pedidoUm.tipo = "Blusinha";
            pedidoUm.cor = "Tanto Faz";

            char generoEscolhido = 'M';

            pedidoUm.genero(generoEscolhido);
            pedidoUm.tamanho = 3;

            Cliente cliente1 = new Cliente();

            cliente1 = pedidoUm.cadastroCliente;

            cliente1.nome = "Marilda da Silva";
            cliente1.ocupacao = "Vendedora";
            cliente1.bairro = "Casa Verde";
            cliente1.idade = 50;


            Console.WriteLine("O pedido é de 1 " + pedidoUm.tipo
                + " da cor " + pedidoUm.cor + ". ");
            Console.WriteLine(pedidoUm.genero(generoEscolhido));
            Console.WriteLine("Separar o tamanho: " + pedidoUm.tamanho);

            Console.WriteLine();
            Console.WriteLine("O nome da cliente é " + cliente1.nome + " e ela é " + cliente1.ocupacao+".");
            Console.WriteLine("Reside no bairro " + cliente1.bairro + " e tem " + cliente1.idade + " anos.");


            Console.ReadLine();
        }
    }
}
